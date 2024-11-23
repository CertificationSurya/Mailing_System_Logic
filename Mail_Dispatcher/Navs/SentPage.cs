using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Dispatcher.Navs
{
    public partial class SentPage : Form
    {
        private readonly Dashboard _dashboard;
        private List<MailDetails> _sentMails = new List<MailDetails>();

        public SentPage(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;

            Task.Run(() => GetSentMails()).Wait();
        }


        private async void GetSentMails() {
            try
            {
                // Fetch Sent Mails asynchronously
                _sentMails = await Lib.GetUserMails();

                //Populate the panel with the fetched data
                populateItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching group details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void populateItem()        {
            // Ensure the method runs on the UI thread
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(populateItem));
                return;
            }

            // Clear existing controls
            mailPanel.Controls.Clear();

            // Dynamically add GroupBox controls for each group
            foreach (MailDetails mail in _sentMails)
            {
                // Create a new GroupBox instance and add it to the panel
                var groupBox = new Mail_Dispatcher.Components.MailBox(mail)
                {
                    Dock = DockStyle.Top, // Adjust layout as needed
                    Margin = new Padding(0),
                };

                // when groupBox is clicked
                //groupBox.Click += (sender, e) => NavigateToViewGroupMembers(groupDetails);
                mailPanel.Controls.Add(groupBox);
            }

            // Optionally refresh the panel
            mailPanel.Refresh();
        }
    }
}
