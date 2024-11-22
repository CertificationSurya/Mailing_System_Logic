using System;
using System.IO;
using System.Net;
using Google.Apis.Auth;
using MailKit;
using MailKit.Security;
using MailKit.Net.Smtp;
using MimeKit;
         
namespace Mail_Dispatcher
{
    public static class Lib
    {
        public enum SideNavigationType
        {
            CreateGroup,
            ViewMail,
            ViewMembers
        }

        public static string defaultImgSrc = @"\codeAndStuff\viva\Mail_Dispatcher\Mail_Dispatcher\default.jpg";
        public static async Task<Image> DownloadImage(string photoURL)
        {
            // Validate the URL
            if (string.IsNullOrWhiteSpace(photoURL))
            {
                throw new ArgumentException("Photo URL cannot be null or empty", nameof(photoURL));
            }

            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] imageData = await webClient.DownloadDataTaskAsync(photoURL);
                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {
                        return Image.FromStream(memoryStream);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to download an image");
                throw new Exception("Failed to download image", ex);
            }
        }



        public static async Task SendEmailAsync(string[] toEmails, string subject, string body)
        {
            string groupName = "I am the Group";
            // TODO: Get Group Members Email


            // send Email
            try
            {
                // Create MimeMessage (Email body, subject, etc.)
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(CredentialManager.Instance.Username, CredentialManager.Instance.Email));

                //// Test
                //message.From.Add(new MailboxAddress("certiSurya", myGmail));

                // TODO: Join table to get members name too. [optional]

                // multiple receipient
                foreach (var email in toEmails)
                {
                    message.To.Add(new MailboxAddress("", email));  // Add recipients
                }

                message.Subject = subject;
                message.Body = new TextPart("plain") { Text = body };

                // Set up SMTP client and connect using OAuth2 token
                using (var smtpClient = new SmtpClient())
                {
                    await smtpClient.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                    // Use OAuth2 for authentication
                    var oauth2Authenticator = new SaslMechanismOAuth2(CredentialManager.Instance.Email, CredentialManager.Instance.credential.Token.AccessToken);
                    await smtpClient.AuthenticateAsync(oauth2Authenticator);

                    // Send the email
                    await smtpClient.SendAsync(message);


                    // Saving Mail To Database



                    Toaster.Instance.ShowNotification("Success: Email Sent", $"Email has been sent to the {groupName}");
                }
            }
            catch (Exception ex)
            {
                //Toaster.Instance.ShowNotification("Error: In Email Sending", $"Email Sending To the Group named {groupName}");
                MessageBox.Show($"Error: {ex.Message}");
            }
        }


    }
}
