using System;
using System.Collections.Generic;

namespace Mail_Dispatcher.Navs
{
    public partial class GroupPage : Form
    {
        private readonly Dashboard _dashboard;
        public GroupPage(Dashboard dashboard)
        {
            _dashboard = dashboard;
            InitializeComponent();
            this.Shown += new EventHandler(EventMapper);
        }

        private void EventMapper(object obj, System.EventArgs e)
        {
            this.createGroupNav.Click += new EventHandler(OpenCreateGroup); 
            this.createGroupNavIcon.Click += new EventHandler(OpenCreateGroup); 
        }


        // open Create Group Page
        private void OpenCreateGroup(object obj, System.EventArgs e) {
            _dashboard.rightNavigator(Lib.SideNavigationType.CreateGroup);
        }
    }
}
