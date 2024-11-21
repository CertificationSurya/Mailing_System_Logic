using System.Net;

namespace Mail_Dispatcher
{
    public static class Lib
    {
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
    }
}
