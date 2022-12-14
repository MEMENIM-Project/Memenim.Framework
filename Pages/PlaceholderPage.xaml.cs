namespace Memenim.Framework.Pages
{
    public partial class PlaceholderPage : PageContent
    {
        public PlaceholderViewModel ViewModel
        {
            get
            {
                return DataContext as PlaceholderViewModel;
            }
        }



        public PlaceholderPage()
        {
            InitializeComponent();
            DataContext = new PlaceholderViewModel();
        }



        protected override void OnEnter(object sender,
            RoutedEventArgs e)
        {
            base.OnEnter(sender, e);

            if (!IsOnEnterActive)
            {
                e.Handled = true;
                return;
            }

            SmileTextBox.Text = GeneratingManager
                .GetRandomSmile();
        }
    }
}
