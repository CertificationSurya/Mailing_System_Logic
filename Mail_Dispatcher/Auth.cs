//using System.IO;
using Google.Apis.PeopleService.v1;
using Google.Apis.Auth.OAuth2; // OAuth2 signin/up
//using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Net;

namespace Mail_Dispatcher
{
    public partial class authForm : Form
    {
        private Output _printer; // var to store Output instance


        private const string AppName = "mail-dispatcher"; // console.cloud.google ko app name
        private static readonly string[] Scopes = { "https://mail.google.com", // for full gmail access. send/receive and so.
            "https://www.googleapis.com/auth/userinfo.profile",
            "https://www.googleapis.com/auth/userinfo.email" };

        public authForm(Output printer) // injection of hamro output dekhaunea/printer 
        {
            InitializeComponent();
            EventMapper();

            _printer = printer; // assigning
        }

        private void EventMapper()
        {
            authBtn.Click += new EventHandler(AuthHandler);
        }

        private async void AuthHandler(object sender, EventArgs e)
        {
            Toaster.ShowNotification("Success", "U");

            try {
                await AuthenticateAsync();
                await GatherUserInfo();

                // Data storage in DB
                //await StoreInDb();
            }
            catch (Exception)
            {
                Toaster.ShowNotification("Validation Error", "Can't validate the user login", NotificationType.Error);
                //_printer.Consoler<string>("Error In Startup. Please leave a message to developer at: certification.surya@gmail.com");
                this.Close();
                throw;
            }

        }


        // get client id and other credential.
        public async Task<UserCredential> AuthenticateAsync()
        {
            // Load client secrets from the credentials.json file
            using (var stream = new FileStream(@"\codeAndStuff\viva\Mail_Dispatcher\Mail_Dispatcher\gmailCredential.json", FileMode.Open, FileAccess.Read))
            {
                var credPath = "token.json"; // Path to store the user token
                var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));

            CredentialManager.Instance.credential = credential;
            }

         // Gotta extract access token and other related stuff
         //_printer.Consoler<object>(CredentialManager.Instance.credential);
         // setting important credential data in CredentialManager            
         return CredentialManager.Instance.credential;
        }

        // get user info
        public async Task GatherUserInfo()
        {
            var credential = CredentialManager.Instance.credential;
            if (credential == null)
            {
                Toaster.ShowNotification("Credential Error", "Invalid Credential or No Credential");
                //_printer.Consoler("No credentials found.");
                return;
            }

            // Initialize the People API client
            var service = new PeopleServiceService(new Google.Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = AppName,
            });

            // Get the user's profile (name, email, and photo URL)
            var request = service.People.Get("people/me");
            request.PersonFields = "names,emailAddresses,photos"; // Fields we want to retrieve

            try
            {
                // Execute the API request
                var profile = await request.ExecuteAsync();

                // Extract and store user details in CredentialManager
                CredentialManager.Instance.Username = profile.Names?[0]?.DisplayName ?? "Anonymous";
                CredentialManager.Instance.Email = profile.EmailAddresses?[0]?.Value ?? "Unknown";
                CredentialManager.Instance.PhotoUrl = profile.Photos?[0]?.Url ?? @"\codeAndStuff\viva\Mail_Dispatcher\Mail_Dispatcher\default.jpg";
                // OR, if not img in device
                //CredentialManager.Instance.PhotoUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Slavery21.jpg/1280px-Slavery21.jpg";

                // downloading userPhoto from url
                if (CredentialManager.Instance.userPhoto == null)
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] imageData = await webClient.DownloadDataTaskAsync(CredentialManager.Instance.PhotoUrl);
                        using (MemoryStream memoryStream = new MemoryStream(imageData))
                        {
                            CredentialManager.Instance.userPhoto = System.Drawing.Image.FromStream(memoryStream);
                        }
                    }
                }

                // Output the user information
                //_printer.Consoler($"Name: {CredentialManager.Instance.Username} \nEmail: {CredentialManager.Instance.Email} \nPhoto URL: {CredentialManager.Instance.PhotoUrl}");
            }
            catch (Exception ex)
            {
                // Handle API request failure
                Toaster.ShowNotification("Error: User Info", "Can't Retrieve User Info", NotificationType.Error);
                //_printer.Consoler($"Failed to retrieve user info: {ex.Message}");
                CredentialManager.Instance.userPhoto = null;
            }
        }

        // store in db If not stored before.

    }
}
