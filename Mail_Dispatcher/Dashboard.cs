using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Google.Apis.PeopleService.v1;
using Mail_Dispatcher.Navs;
using Mail_Dispatcher.Navs.SubNavs;

namespace Mail_Dispatcher
{
    public partial class Dashboard : Form
    {
        public enum NavigationType
        {
            Inbox,
            Sent,
            Compose,
            Group
        }

        public Dashboard()
        {
            InitializeComponent();
            EventMapper();

            // download image only when the window visible xa natra no download
            this.Shown += new EventHandler(Dashboard_Shown);
        }

        // mapping event to method
        private void EventMapper()
        {
            inboxNav.Click += (sender, e) => Navigator(NavigationType.Inbox);
            sentNav.Click += (sender, e) => Navigator(NavigationType.Sent);
            composeNav.Click += (sender, e) => Navigator(NavigationType.Compose);
            groupNav.Click += (sender, e) => Navigator(NavigationType.Group);
        }

        private async void Dashboard_Shown(object sender, EventArgs e)
        {
            await Setup();

            // Full Screen Ko lagi
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);


            // initial left and right form
            loadLeftForm(new InboxPage(this));
            loadRightForm(new NothingDoneYet());
        }

        private void loadLeftForm(Form newForm)
        {
            // Remove existing controls in the panel
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }

            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(newForm);
            this.mainpanel.Tag = newForm;
            newForm.Show();
        }

        private void loadRightForm(Form newForm)
        {
            // Remove existing controls in the panel
            if (this.sidePanel.Controls.Count > 0)
            {
                this.sidePanel.Controls.RemoveAt(0);
            }

            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            this.sidePanel.Controls.Add(newForm);
            this.sidePanel.Tag = newForm;

            newForm.Show();
        }


        // Setup
        private async Task Setup()
        {
            if (CredentialManager.Instance.PhotoUrl != null)
            {
                this.userPic.Image = await Lib.DownloadImage(CredentialManager.Instance.PhotoUrl);
            }
            else
            {
                this.userPic.ImageLocation = Lib.defaultImgSrc;
            }
        }

        // Navigator

        // leftFormNavigator
        private void Navigator(NavigationType navItem = NavigationType.Inbox)
        {
            switch (navItem)
            {
                case NavigationType.Inbox:
                    loadLeftForm(new InboxPage(this));
                    break;

                case NavigationType.Sent:
                    loadLeftForm(new SentPage(this));
                    break;

                case NavigationType.Compose:
                    loadLeftForm(new ComposePage(this));
                    break;

                case NavigationType.Group:
                    loadLeftForm(new GroupPage(this));
                    break;

            }

        }


        // rightFormNavigator
        public void rightNavigator(Lib.SideNavigationType sideNavType, int id = 1)
        {
            switch (sideNavType)
            {
                case Lib.SideNavigationType.CreateGroup:
                    loadRightForm(new CreateGroup());
                    break;

                case Lib.SideNavigationType.ViewMail:
                    loadRightForm(new ViewMail(id));
                    break;

                case Lib.SideNavigationType.ViewMembers:
                    loadRightForm(new ViewGroupMembers(id));
                    break;
            }

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
