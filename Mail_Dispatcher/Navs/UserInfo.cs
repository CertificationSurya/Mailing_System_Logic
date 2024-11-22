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
    public partial class UserInfo : Form
    {
        public UserInfo()
        {
            InitializeComponent();
            this.Load += new EventHandler(centerPos);
            EventMapper();
        }

        private void EventMapper()
        {
            this.cross.Click += ((object sender, EventArgs e) => this.Close());
        }

        private void centerPos(object sender, EventArgs e)
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(x, y);

            Setup();
        }

        private async void Setup()
        {
            if (CredentialManager.Instance.PhotoUrl != null)
            {
                this.userPic.Image = await Lib.DownloadImage(CredentialManager.Instance.PhotoUrl);
            }
            else
            {
                this.userPic.ImageLocation = Lib.defaultImgSrc;
            }

            this.username.Text = CredentialManager.Instance.Username;
            this.userEmail.Text = CredentialManager.Instance.Email;
        }

        private void cross_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
