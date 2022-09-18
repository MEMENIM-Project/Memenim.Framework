namespace Memenim.Framework.Flyouts
{
    public partial class SettingsFlyout : FlyoutContent
    {
        public string AppVersion { get; private set; }



        public SettingsFlyout()
        {
            InitializeComponent();
            DataContext = this;

            AppVersion = $"v{SettingsManager.AppSettings.AppVersion}";

            LocalizationUtils.LocalizationUpdated += OnLocalizationUpdated;
        }

        ~SettingsFlyout()
        {
            LocalizationUtils.LocalizationUpdated -= OnLocalizationUpdated;
        }



        public void Show()
        {
            IsOpen = true;
        }

        public void Hide()
        {
            IsOpen = false;
        }



        private void OnLocalizationUpdated(object sender,
            LocalizationEventArgs e)
        {

        }



        private void OpenDiscordLinkButton_Click(object sender,
            RoutedEventArgs e)
        {
            const string link = "https://discord.gg/yhATVBWxZG";

            LinkUtils.OpenLink(link);
        }

        private void OpenTelegramLinkButton_Click(object sender,
            RoutedEventArgs e)
        {
            const string link = "https://t.me/joinchat/Vf9B3XM5SM-zUbkf";

            LinkUtils.OpenLink(link);
        }
    }
}
