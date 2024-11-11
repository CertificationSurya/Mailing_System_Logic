using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;

namespace Project_vz_Alpha
{
    public partial class AddUC : UserControl
    {
        private List<Attachment> attachments = new List<Attachment>(); // Store attachments

        public AddUC()
        {
            InitializeComponent();
        }

        private void AddUC_Load(object sender, EventArgs e)
        {
            // Initially hide the extra recipient fields
            emailField2.Visible = false;
            emailField3.Visible = false;
            emailField4.Visible = false;
            emailField5.Visible = false;
        }

        // Event handler for the "Add More Recipients" button click
        private void addMoreRecipientsButton_Click(object sender, EventArgs e)
        {
            // Show extra email fields one by one
            if (!emailField2.Visible)
                emailField2.Visible = true;
            else if (!emailField3.Visible)
                emailField3.Visible = true;
            else if (!emailField4.Visible)
                emailField4.Visible = true;
            else if (!emailField5.Visible)
                emailField5.Visible = true;
            else
                MessageBox.Show("All recipient fields are already visible.");
        }

        // Method to attach a file
        private void AttachFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;  // Allow multiple files
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    Attachment attachment = new Attachment(filePath);
                    attachments.Add(attachment);  // Add to list of attachments
                }
                MessageBox.Show("Files attached successfully.");
            }
        }

        // Event handler for the "Send" button click
        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("your email@gmail.com");

                // Add the main recipient from the first email field
                if (!string.IsNullOrWhiteSpace(to.Text))
                {
                    mail.To.Add(to.Text);
                }

                // Add more recipients if their fields are visible and not empty
                AddRecipientIfVisible(emailField2, mail);
                AddRecipientIfVisible(emailField3, mail);
                AddRecipientIfVisible(emailField4, mail);
                AddRecipientIfVisible(emailField5, mail);

                // Set subject and body
                mail.Subject = Subject.Text;
                mail.Body = richTextBoxBody.Text; // Use the rich text body

                // Add attachments
                foreach (var attachment in attachments)
                {
                    mail.Attachments.Add(attachment);
                }

                // Set up SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential("your email@gmail.com", "16 digit password");
                smtpClient.EnableSsl = true;

                // Send email
                smtpClient.Send(mail);
                MessageBox.Show("Email sent successfully!");

                // Clear the input fields
                ClearInputFields();
                attachments.Clear(); // Clear attachments
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email. Error: " + ex.Message);
            }
        }

        // Helper method to add recipients if the field is visible and not empty
        private void AddRecipientIfVisible(TextBox emailField, MailMessage mail)
        {
            if (emailField.Visible && !string.IsNullOrWhiteSpace(emailField.Text))
            {
                mail.To.Add(emailField.Text);
            }
        }

        // Method to clear all input fields after sending the email
        private void ClearInputFields()
        {
            to.Clear();           // Clear the first recipient field
            emailField2.Clear();  // Clear additional recipient fields
            emailField3.Clear();
            emailField4.Clear();
            emailField5.Clear();
            Subject.Clear();      // Clear the subject field
            richTextBoxBody.Clear(); // Clear the rich text body

            // Optionally hide extra email fields
            emailField2.Visible = false;
            emailField3.Visible = false;
            emailField4.Visible = false;
            emailField5.Visible = false;
        }

        private void BoldButton_Click(object sender, EventArgs e)
        {
            if (richTextBoxBody.SelectionLength > 0)
            {
                // Get the current selection start and length
                int selectionStart = richTextBoxBody.SelectionStart;
                int selectionLength = richTextBoxBody.SelectionLength;

                if (richTextBoxBody.SelectionFont != null)
                {
                    FontStyle style = richTextBoxBody.SelectionFont.Style;
                    style = richTextBoxBody.SelectionFont.Bold ? style & ~FontStyle.Bold : style | FontStyle.Bold;
                    richTextBoxBody.SelectionFont = new Font(richTextBoxBody.SelectionFont, style);
                }
                else
                {
                    // No font selected, apply default bold
                    richTextBoxBody.SelectionFont = new Font(richTextBoxBody.Font, FontStyle.Bold);
                }

                // Reapply the selection
                richTextBoxBody.SelectionStart = selectionStart;
                richTextBoxBody.SelectionLength = selectionLength;
            }
            else
            {
                MessageBox.Show("Please select some text to format.");
            }
        }

        private void ItalicButton_Click(object sender, EventArgs e)
        {
            if (richTextBoxBody.SelectionLength > 0)
            {
                // Get the current selection start and length
                int selectionStart = richTextBoxBody.SelectionStart;
                int selectionLength = richTextBoxBody.SelectionLength;

                if (richTextBoxBody.SelectionFont != null)
                {
                    FontStyle style = richTextBoxBody.SelectionFont.Style;
                    style = richTextBoxBody.SelectionFont.Italic ? style & ~FontStyle.Italic : style | FontStyle.Italic;
                    richTextBoxBody.SelectionFont = new Font(richTextBoxBody.SelectionFont, style);
                }
                else
                {
                    // No font selected, apply default italic
                    richTextBoxBody.SelectionFont = new Font(richTextBoxBody.Font, FontStyle.Italic);
                }

                // Reapply the selection
                richTextBoxBody.SelectionStart = selectionStart;
                richTextBoxBody.SelectionLength = selectionLength;
            }
            else
            {
                MessageBox.Show("Please select some text to format.");
            }
        }

        private void UnderlineButton_Click(object sender, EventArgs e)
        {
            if (richTextBoxBody.SelectionLength > 0)
            {
                // Get the current selection start and length
                int selectionStart = richTextBoxBody.SelectionStart;
                int selectionLength = richTextBoxBody.SelectionLength;

                if (richTextBoxBody.SelectionFont != null)
                {
                    FontStyle style = richTextBoxBody.SelectionFont.Style;
                    style = richTextBoxBody.SelectionFont.Underline ? style & ~FontStyle.Underline : style | FontStyle.Underline;
                    richTextBoxBody.SelectionFont = new Font(richTextBoxBody.SelectionFont, style);
                }
                else
                {
                    // No font selected, apply default underline
                    richTextBoxBody.SelectionFont = new Font(richTextBoxBody.Font, FontStyle.Underline);
                }

                // Reapply the selection
                richTextBoxBody.SelectionStart = selectionStart;
                richTextBoxBody.SelectionLength = selectionLength;
            }
            else
            {
                MessageBox.Show("Please select some text to format.");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Subject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
