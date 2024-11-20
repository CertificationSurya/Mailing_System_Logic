using System.Text.Json; // hamro json lai serialize garna to indented-string.


namespace Mail_Dispatcher
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        //
        public void Consoler<T>(T input)
        {
            string printerString = Serialize<T>(input);

            if (this.consoler != null)
            {
                this.consoler.Text = printerString;

                if (CredentialManager.Instance.userPhoto != null)
                {
                    this.photoConsoler.Image = CredentialManager.Instance.userPhoto;
                }
                this.Show();
            }
            else {
                MessageBox.Show("nahi hua initialized hamra consoler");
            }
        }


        // helper
        private static readonly JsonSerializerOptions s_writeOptions = new()
        {
            WriteIndented = true
        };
        private string Serialize<T>(T value)
        {
            return JsonSerializer.Serialize<T>(value, s_writeOptions);
        }
    }
}
