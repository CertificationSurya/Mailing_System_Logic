
namespace Mail_Dispatcher.Navs
{
    public partial class ComposePage : Form
    {
        private readonly Dashboard _dashboard;
        public ComposePage(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
            this.Load += new EventHandler(centerPos);
            EventMapper();

            // setUp
            this.fromEmail.Text = CredentialManager.Instance.Email;
        }


        private void EventMapper()
        {
            this.cross.Click += new EventHandler(ClosePage);
        }


        // position page to center
        private void centerPos(object sender, EventArgs e)
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(x, y);
        }

        // cross btn event handler
        private void ClosePage(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
