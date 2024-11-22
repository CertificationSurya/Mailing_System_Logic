
using System.Linq;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using Dapper;

namespace Mail_Dispatcher.Navs.SubNavs
{
    public partial class CreateGroup : Form
    {
        // Gmail Checker Regex
        private Regex gmailRegex = new Regex(@"^[a-zA-Z0-9._%+-]+@gmail\.com$", RegexOptions.IgnoreCase);

        public CreateGroup()
        {
            InitializeComponent();
            EventMapper();
        }

        private void EventMapper() {
            createGroupBtn.Click += new EventHandler(CreateGroupAction);
        }



        private void CreateGroupAction(object sender, EventArgs e)
        {
            try {
                string groupName = groupNameField.Text.Trim();
            
                using (SqlConnection connection = DBandSchemaManager.Instance.GetConnection()) {
                   if (string.IsNullOrWhiteSpace(groupName))
                    {
                        throw new Exception("Invalid Group Name: Group name cannot be empty or just whitespace.");
                    }
                    else
                    {
                        int count = connection.ExecuteScalar<int>(Queries.Group.CheckGroupName, new { GroupName = groupName });
                        if (count > 0) {
                            throw new Exception($"Group Named {groupName} already Exist");
                        }
                    }

                    string[] memberGmailsArray = memberListField.Text.Split(',')
                                .Where(field => !string.IsNullOrWhiteSpace(field)) // Exclude empty or whitespace fields
                               .Select(field => field.Trim()) // Trim each field
                               .Where(email => gmailRegex.IsMatch(email))
                               .Distinct()
                               .ToArray();

                    string memberGmails = string.Join(",", memberGmailsArray.Select(email => $"\"{email}\""));
                    //MessageBox.Show(memberGmails);

                    var parameters = new {
                        GroupName = groupName,
                        OwnerEmail = CredentialManager.Instance.Email,
                        OwnerId = CredentialManager.Instance.UserId,
                        OtherEmails= memberGmails
                    };


                    int groupId = connection.ExecuteScalar<int>(Queries.Group.CreateGroupAndGetId, parameters);
                    //MessageBox.Show(groupId.ToString());

                    // Notify the user
                    if (groupId > 0) {
                        Toaster.Instance.ShowNotification("Success: Group Creation", $"Successfully Created the Group Named {groupName}");

                        // user update
                        updateGroupIdOfUser(CredentialManager.Instance.Email, groupId);

                        foreach (string gmail in memberGmailsArray) {
                            MessageBox.Show(gmail);
                            // member update
                            updateGroupIdOfUser(gmail, groupId);
                        }

                    }
                    else {
                        throw new Exception("Couldn't Create the group");
                        //Toaster.Instance.ShowNotification("Error: Group Creation", "Couldn't Create the group", NotificationType.Error);
                    }
                }
            }
            catch (Exception ex) {
                Toaster.Instance.ShowNotification("Error: Group Creation", ex.Message, NotificationType.Error);
            }
        }

        private void updateGroupIdOfUser(string gmail, int groupId) {
            var updateParams = new
            {
                Email = gmail,
                GroupId = groupId,
            };

            using (SqlConnection connection = DBandSchemaManager.Instance.GetConnection())
            {
                int rowsAffected = connection.Execute(Queries.User.UpdateUserGroupJoined, updateParams);
                if (rowsAffected == 0)
                {
                    Toaster.Instance.ShowNotification(
                        "Error: Group Update",
                        $"Could not update groupJoined for user: {gmail}",
                        NotificationType.Error
                    );
                }
            }


        }
    }
}
