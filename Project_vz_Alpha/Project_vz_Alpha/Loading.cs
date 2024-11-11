using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Project_vz_Alpha
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Enabled = true; // Start the timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); // Stop the timer to prevent it from firing again

            // Create an instance of Form2
            Dashboard form2 = new Dashboard();

            // Show Form2
            form2.Show();

            // Close the current form (Form1)
            pictureBox1.Visible = false;
            this.Hide();
        }
    }
}
