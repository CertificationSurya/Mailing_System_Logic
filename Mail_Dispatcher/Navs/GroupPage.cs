using System;
using System.Collections.Generic;

namespace Mail_Dispatcher.Navs
{
    public partial class GroupPage : Form
    {
        private List<GroupDetails> _groupDetails = new List<GroupDetails>();

        private readonly Dashboard _dashboard;
        public GroupPage(Dashboard dashboard)
        {
            _dashboard = dashboard;
            InitializeComponent();

            //Task.Run(() => JoinedGroupDetails()).Wait();
            this.Shown += new EventHandler(EventMapper);
        }

        private void EventMapper(object obj, System.EventArgs e)
        {
            this.createGroupNav.Click += new EventHandler(OpenCreateGroup);
        }

        //private async void JoinedGroupDetails() {
        //    _groupDetails = await Lib.userJoinedGroups();
        //}

        private async void JoinedGroupDetails()
        {
            try
            {
                // Fetch joined group details asynchronously
                _groupDetails = await Lib.userJoinedGroups();

                // Populate the panel with the fetched data
                populateItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching group details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // open Create Group Page
        private void OpenCreateGroup(object obj, System.EventArgs e)
        {
            _dashboard.rightNavigator(Lib.SideNavigationType.CreateGroup);
        }

        private void populateItem()
        {
            // Ensure the method runs on the UI thread
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(populateItem));
                return;
            }

            // Clear existing controls
            groupsPanel.Controls.Clear();

            // Dynamically add GroupBox controls for each group
            foreach (GroupDetails groupDetails in _groupDetails) {
                // Create a new GroupBox instance and add it to the panel
                var groupBox = new Mail_Dispatcher.Components.GroupBox(groupDetails)
                {
                    Dock = DockStyle.Top, // Adjust layout as needed
                    Margin = new Padding(10)
                };

                // when groupBox is clicked
                groupBox.Click += (sender, e) => NavigateToViewGroupMembers(groupDetails);
                groupsPanel.Controls.Add(groupBox);
            }

            // Optionally refresh the panel
            groupsPanel.Refresh();
        }


        private void NavigateToViewGroupMembers(GroupDetails groupDetails) {
            _dashboard.rightNavigator(Lib.SideNavigationType.ViewMembers, groupDetails.GroupId);
        }
    }
}
