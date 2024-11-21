
namespace Mail_Dispatcher.Navs
{
    public partial class ComposePage : Form
    {
        private readonly Dashboard _dashboard;
        public ComposePage(Dashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
        }
    }
}
