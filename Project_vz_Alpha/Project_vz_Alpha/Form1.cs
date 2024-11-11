using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Project_vz_Alpha
{
    public partial class Dashboard : Form
    {

        // Import necessary Windows API functions
        // import tah gare tara idk use mah aauxa ki nai because smaller window bata suru gareko theo so top pannel mah use gareko theo 
// hallauna milne bhanera , aba tah maximized window mah xa 

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public Dashboard()
        {
            InitializeComponent();

            // Subscribe to panel events
            panel1.MouseDown += new MouseEventHandler(panel7_MouseDown);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonColorButton1_SelectedColorChanged(object sender, Krypton.Toolkit.ColorEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            add.Paint += new PaintEventHandler(button1_Paint);

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }






        private void button1_Paint(object? sender, PaintEventArgs e)
        {

            // Set up graphics for smooth rendering
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Define a circle for the button
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, add.Width - 2, add.Height - 2);

            // Clip the button to the circular path
            add.Region = new Region(path);

            // Optionally draw a border for the circle
            e.Graphics.DrawEllipse(Pens.Orange, 0, 0, add.Width - 1, add.Height - 1);
        }

        private void panel7_MouseDown(object? sender, MouseEventArgs e)
        {

            // Release the mouse capture and send the message to move the window
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            };
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void box_MouseEnter(object sender, EventArgs e)
        {
            box.BackColor = Color.LightGray;
        }

        private void sent_MouseEnter(object sender, EventArgs e)
        {
            sent.BackColor = Color.LightGray;
        }

        private void trash_MouseEnter(object sender, EventArgs e)
        {
            trash.BackColor = Color.LightGray;
        }

        private void trash_MouseLeave(object sender, EventArgs e)
        {
            trash.BackColor = Color.Transparent;
        }

        private void sent_MouseLeave(object sender, EventArgs e)
        {
            sent.BackColor = Color.Transparent;
        }

        private void box_MouseLeave(object sender, EventArgs e)
        {
            box.BackColor = Color.Transparent;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (adduc1.Visible)
            {
                adduc1.Visible = false;
                adduc1.SendToBack();
                panel6.BringToFront();
                // Send the user control to the back
            }
            else
            {
                adduc1.Visible = true;
                adduc1.BringToFront();
                panel6.SendToBack();// Bring the user control to the front
            }
        }

        private void box_Click(object sender, EventArgs e)
        {
            
            inboxuc1.BringToFront();
            sentuc1.SendToBack();

        }

    
        private void sent_Click(object sender, EventArgs e)
        {

            sentuc1.BringToFront();
            inboxuc1.SendToBack();
        }
    }
}


