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
        }

        private async void Dashboard_Shown(object sender, EventArgs e)
        {
            await Setup();
            loadLeftForm(new InboxPage());
        }

        public void loadLeftForm(Form Form)
        {
            // Remove existing controls in the panel
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }

            Form newForm = Form as Form;

            // Embed the form into the panel
            newForm.TopLevel = true;
            newForm.Dock = DockStyle.Fill;
            //this.mainpanel.Controls.Add(newForm);
            //this.mainpanel.Tag = newForm;
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
        private void Navigator(NavigationType navItem = NavigationType.Inbox)
        {
            switch (navItem)
            {
                case NavigationType.Inbox:
                    loadLeftForm(new InboxPage());
                    break;

                case NavigationType.Sent:
                    loadLeftForm(new SentPage());
                    break;

                case NavigationType.Compose:
                    loadLeftForm(new ComposePage());
                    break;

                case NavigationType.Group:
                    loadLeftForm(new GroupPage());
                    break;

            }

        }

        private void inboxNav_Click(object sender, EventArgs e)
        {
            Navigator(NavigationType.Inbox);
        }
    }
}
