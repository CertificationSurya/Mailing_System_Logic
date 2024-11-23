using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mail_Dispatcher.Components
{
    public partial class MailBox : UserControl
    {
        public MailBox(MailDetails mail)
        {
            InitializeComponent();

            this.groupLabel.Text = mail.GroupName;
            this.subjectLabel.Text = mail.Subject;
            this.senderLabel.Text = mail.SenderEmail;
            this.createdAtLabel.Text = mail.CreatedAt.ToLocalTime().ToString();
        }

    }
}
