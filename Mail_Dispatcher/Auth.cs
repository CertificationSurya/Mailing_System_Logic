using System;
using System.IO;
using Google.Apis.Auth.OAuth2; // OAuth2 signin/up
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace Mail_Dispatcher
{
    public partial class authForm : Form
    {
        private const string AppName = "mail-dispatcher"; // console.cloud.google ko app name
        private static readonly string[] Scopes = { "https://mail.google.com" }; // for full gmail access. send/receive and so.

        public authForm()
        {
            InitializeComponent();
            EventMapper();
        }

        private void EventMapper()
        {
            authBtn.Click += new EventHandler(AuthHandler);
        }

        private async void AuthHandler(object sender, EventArgs e)
        {
            await AuthenticateAsync();
        }


        // get client id and other credential.
        public static async Task<UserCredential> AuthenticateAsync()
        {
            // Load client secrets from the credentials.json file
            using (var stream = new FileStream("\\codeAndStuff\\viva\\Mail_Dispatcher\\Mail_Dispatcher\\gmailCredential.json", FileMode.Open, FileAccess.Read))
            {
                var credPath = "token.json"; // Path to store the user token
                var credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true));

                MessageBox.Show($"{credential.ToString()}");
                Console.WriteLine("User authenticated successfully.");
                return credential;
            }
        }
    }
}
