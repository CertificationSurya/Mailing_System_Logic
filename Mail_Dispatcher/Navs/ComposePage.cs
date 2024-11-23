
using Dapper;
using Microsoft.Data.SqlClient;
using MimeKit;
using System.Text.Json;

namespace Mail_Dispatcher.Navs
{
    public partial class ComposePage : Form
    {
        public class GroupMembersAndId
        {
            public int Id { get; set; }  // Group ID
            public string Members { get; set; }  // JSON string representing the members (emails)
        }


        private readonly Dashboard _dashboard;
        private List<GroupDetails> _groupDetails = new List<GroupDetails>();
        public ComposePage(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
            this.Load += new EventHandler(centerPos);
            EventMapper();

            Task.Run(() => JoinedGroupDetails()).Wait();

            // setUp
            this.fromEmail.Text = CredentialManager.Instance.Email;
            //foreach (GroupDetails group in _groupDetails) {
            //    this.groupField.Items.Add(group.GroupName);
            //}
        }


        private void EventMapper()
        {
            this.cross.Click += new EventHandler(ClosePage);
            this.sendBtn.Click += new EventHandler(SendGmailToGroup);
        }


        // position page to center
        private async void centerPos(object sender, EventArgs e)
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(x, y);

            // setup
            PopulateGroupField();
            this.userPic.Image = await Lib.DownloadImage(CredentialManager.Instance.PhotoUrl);
        }

        // cross btn event handler
        private void ClosePage(object sender, EventArgs e)
        {
            this.Close();
        }

        // get groups
        private async void JoinedGroupDetails()
        {
            try
            {
                // Fetch joined group details asynchronously
                _groupDetails = await Lib.userJoinedGroups();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching group details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // populate input field
        private void PopulateGroupField()
        {
            this.groupField.Items.Clear(); // Clear existing items
            foreach (GroupDetails group in _groupDetails)
            {
                this.groupField.Items.Add(group.GroupName);
            }
        }


        private async void SendGmailToGroup(object sender, EventArgs e)
        {
            string subject = this.subjectField.Text;
            string body = this.bodyField.Text;
            string toSendGroupName = this.groupField.Text;

            List<string> membersGmail = new List<string>();

            if (string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(body) || string.IsNullOrWhiteSpace(toSendGroupName))
            {
                Toaster.Instance.ShowNotification("Error: Invalid Input", "Invalid Input Given. Try Again", NotificationType.Error);
                return;
            }

            using (SqlConnection connection = DBandSchemaManager.Instance.GetConnection())
            {

                try {
                    // members, id
                    GroupMembersAndId result = await connection.QuerySingleOrDefaultAsync<GroupMembersAndId>(Queries.Group.GetMembersArrayByGroupName, new { GroupName = toSendGroupName });

                    if (result != null && !string.IsNullOrEmpty(result.Members))
                    {
                        // Deserialize the 'members' JSON into a List<string>
                        membersGmail = JsonSerializer.Deserialize<List<string>>(result.Members);
                        membersGmail = membersGmail.Where(email => email != CredentialManager.Instance.Email).ToList();
                    }
                    int groupId = result.Id;


                    // pathauxa msg. Vitra Aafui Notification Pathauxa
                    await Lib.SendEmailAsync(toSendGroupName, membersGmail, subject, body);

                    // store in DB
                    var parameters = new {
                        Subject = subject,
                        Body = body,
                        GroupId = groupId,
                        GroupName = toSendGroupName,
                        SenderId = CredentialManager.Instance.UserId,
                        SenderEmail = CredentialManager.Instance.Email
                    };

                    int rowsAffected = await connection.ExecuteAsync(Queries.Mail.CreateMail, parameters);

                    if (rowsAffected == 0) { 
                        throw new Exception();
                    }


                }
                catch (Exception)
                {
                    Toaster.Instance.ShowNotification("Error: Mail Sending", $"Failed To Send Mail to group {toSendGroupName}", NotificationType.Error);
                }
            }
        }
    }
}
