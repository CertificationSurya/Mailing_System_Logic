
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Imap;
using MailKit.Search;
using MimeKit;
using MailKit.Net.Pop3;
using MailKit;
using MailKit.Security;


namespace Project_vz_Alpha
{
    public partial class InboxUC : UserControl
    {
        // List to store MimeMessage objects
        private List<MimeMessage> emailList = new List<MimeMessage>();

        // Token to manage the idle cancellation
        private CancellationTokenSource? idleCancellationTokenSource;

        public InboxUC()
        {
            InitializeComponent();

            // Start the background task for real-time email fetching
            Task.Run(() => IdleForRealTimeEmailsAsync());
        }

        // Async method for IMAP IDLE (real-time email notifications)
        public async Task IdleForRealTimeEmailsAsync()
        {
            using (var client = new ImapClient())
            {
                try
                {
                    await client.ConnectAsync("imap.gmail.com", 993, SecureSocketOptions.SslOnConnect);
                    await client.AuthenticateAsync("youremail@gmail.com", "16 digit app password");  // gmail+password validation gareko xaina , external class bata garnu milxa hola idk if DB use garnu ki nai 

                    client.Inbox.Open(FolderAccess.ReadOnly);

                    idleCancellationTokenSource = new CancellationTokenSource();

                    // Continuously check for new email notifications
                    while (!idleCancellationTokenSource.Token.IsCancellationRequested)
                    {
                        try
                        {
                            // Wait for server notifications (IMAP IDLE)
                            await client.IdleAsync(idleCancellationTokenSource.Token);

                            // If notified, fetch new emails
                            Invoke((MethodInvoker)(() => ReceiveEmails()));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error during IMAP IDLE: {ex.Message}");
                        }

                        // Optional small delay between idle calls
                        await Task.Delay(1000);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error connecting or authenticating: {ex.Message}");
                }
                finally
                {
                    await client.DisconnectAsync(true);
                }
            }
        }

        // Method to fetch and display the latest 10 emails
        public void ReceiveEmails()
        {
            using (var client = new ImapClient())
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate("emailthing@gmail.com", "16digit app password");

                client.Inbox.Open(FolderAccess.ReadOnly);

                // Clear previous data
                emailList.Clear();
                flowLayoutPanelLabels.Controls.Clear();

                // Get the total count of emails
                int messageCount = client.Inbox.Count;
                int endIndex = messageCount - 1; // Latest email
                int startIndex = Math.Max(0, messageCount - 10); // Start from the 10th latest email

                // Loop through the latest 10 emails (descending order)
                for (int index = endIndex; index >= startIndex; index--)
                {
                    MimeMessage message = client.Inbox.GetMessage(index);

                    // Add the message to the list
                    emailList.Add(message);

                    // Extract the sender's name and email subject
                    var mailbox = message.From.Mailboxes.FirstOrDefault();
                    string senderName = mailbox != null && !string.IsNullOrEmpty(mailbox.Name)
                                        ? mailbox.Name
                                        : mailbox?.Address ?? "Unknown Sender"; // Fallback to email address or "Unknown Sender"

                    string subject = !string.IsNullOrEmpty(message.Subject) ? message.Subject : "No Subject"; // Default if no subject

                    // Combine sender's name and subject
                    string displayText = $"{senderName}: {subject}";

                    // Create a label for each sender and subject
                    Label emailLabel = new Label
                    {
                        Text = displayText,
                        AutoSize = false, // Disable AutoSize to set a custom width
                        Cursor = Cursors.Hand,
                        Tag = emailList.Count - 1, // Store the index in the tag
                        BackColor = (emailList.Count % 2 == 0) ? Color.LightCyan : Color.WhiteSmoke,
                        Margin = new Padding(0, 10, 0, 10), // Top and bottom margin of 10px
                        TextAlign = ContentAlignment.MiddleLeft, // Align text to the left
                        Height = 60 // Set a fixed height
                    };

                    // Set the width of the label to fill the FlowLayoutPanel's width
                    emailLabel.Width = flowLayoutPanelLabels.ClientSize.Width;

                    // Make sure the label resizes if the FlowLayoutPanel is resized
                    emailLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;

                    // Assign the click event
                    emailLabel.Click += EmailLabel_Click;

                    // Add the label to the FlowLayoutPanel
                    flowLayoutPanelLabels.Controls.Add(emailLabel);
                }

                client.Disconnect(true);
            }
        }


        private void EmailLabel_Click(object? sender, EventArgs e)
        {
            // Handle click for the label to display the email body
            Label? clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                int emailIndex = (int)clickedLabel.Tag;

                if (emailIndex >= 0 && emailIndex < emailList.Count)
                {
                    // Retrieve the selected email
                    MimeMessage selectedMessage = emailList[emailIndex];

                    // Clear the RichTextBox first
                    richTextBoxEmails.Clear();

                    // 1. "From: (email name)" - Small Font
                    var fromAddress = selectedMessage.From.Mailboxes.FirstOrDefault();
                    string senderInfo = fromAddress != null && !string.IsNullOrEmpty(fromAddress.Name)
                                        ? $"{fromAddress.Name} ({fromAddress.Address})"
                                        : fromAddress?.Address ?? "Unknown Sender";

                    // Set small font for "From" line
                    richTextBoxEmails.SelectionFont = new Font("Arial", 10, FontStyle.Regular);
                    richTextBoxEmails.AppendText($"       From: ");
                    richTextBoxEmails.SelectionBackColor = Color.Gainsboro;
                    richTextBoxEmails.AppendText($"{senderInfo}\n");
                    richTextBoxEmails.SelectionBackColor = Color.Transparent;

                  
                    // 2. Add a thin line as a separator
                    richTextBoxEmails.SelectionFont = new Font("Tahoma", 10, FontStyle.Regular);
                    richTextBoxEmails.AppendText(" \n");

                

                    // 3. "Subject" - Big Font
                    string subject = !string.IsNullOrEmpty(selectedMessage.Subject) ? selectedMessage.Subject : "No Subject";

                    // Set big font for "Subject"
                    richTextBoxEmails.SelectionFont = new Font("Arial", 16, FontStyle.Regular);
                    richTextBoxEmails.AppendText($"     {subject}\n");

                    // 4. Body of the email - Medium Font
                    string body = selectedMessage.TextBody ?? "     No content available";

                    // Set medium font for email body
                    richTextBoxEmails.SelectionFont = new Font("Arial", 12, FontStyle.Regular);
                    richTextBoxEmails.AppendText($"     \n\t{body}\n");

                    // Optionally, scroll to the top
                    richTextBoxEmails.SelectionStart = 0;
                    richTextBoxEmails.ScrollToCaret();
                }
            }
        }



        // Button click to fetch emails manually
        private void button1_Click(object sender, EventArgs e)
        {
            ReceiveEmails();
        }

        private void flowLayoutPanelLabels_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelLabels_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
