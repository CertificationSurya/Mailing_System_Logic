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

            Task.Run(() => JoinedGroupDetails()).Wait();
            this.Shown += new EventHandler(EventMapper);
        }

        private void EventMapper(object obj, System.EventArgs e)
        {
            this.createGroupNav.Click += new EventHandler(OpenCreateGroup);
        }

        private async void JoinedGroupDetails() {
            _groupDetails = await Lib.userJoinedGroups();
        }


        // open Create Group Page
        private void OpenCreateGroup(object obj, System.EventArgs e)
        {
            _dashboard.rightNavigator(Lib.SideNavigationType.CreateGroup);
        }

    }
}
