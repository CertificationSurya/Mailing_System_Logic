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
    public partial class GroupBox : UserControl
    {
        //public GroupBox()
        //{
        //    InitializeComponent();
        //}

        public GroupBox(GroupDetails groupDetails) {
            InitializeComponent();
            this.groupName.Text = groupDetails.GroupName;
            this.ownerName.Text = groupDetails.OwnerEmail;
            this.memberCount.Text = $"Members: ${groupDetails.MemberCount}";
            this.createdAt.Text = groupDetails.CreatedAt.ToLocalTime().ToString();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
