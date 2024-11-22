#nullable enable

// singleton
using Google.Apis.Auth.OAuth2;

namespace Mail_Dispatcher
{
    public class CredentialManager
    {
        // Step 2: Create a private static variable to hold the single instance of the class
        private static CredentialManager _instance;

        // Step 3: Private constructor to prevent direct instantiation
        private CredentialManager() { }

        // Step 4: Public static method to get the instance of the class
        public static CredentialManager Instance
        {
            get
            {
                // Create the instance if it doesn't exist yet
                if (_instance == null)
                {
                    _instance = new CredentialManager();
                }
                return _instance;
            }
        }

        // Example properties to hold credentials and user info
        public string Username { get; set; }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string PhotoUrl { get; set; }
        public System.Drawing.Image userPhoto { get; set; }
        public UserCredential credential { get; set; }

        // Optionally, add methods to manage or validate credentials
        public bool ValidateCredentials()
        {
            // Ensure the credentials are valid (non-empty)
            return !string.IsNullOrEmpty(credential.Token.AccessToken) && !string.IsNullOrEmpty(credential.Token.RefreshToken);
        }

        // You can also add a method to clear sensitive data (like tokens)
        public void ClearCredentials()
        {
            credential = null;
            Username = string.Empty;
            Email = string.Empty;
            PhotoUrl = string.Empty;
            userPhoto = null;
        }
    }
}
