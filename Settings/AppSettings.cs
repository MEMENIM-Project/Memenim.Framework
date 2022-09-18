using RIS.Settings;
using RIS.Settings.Ini;

namespace Memenim.Framework.Settings
{
    public sealed class AppSettings : IniSettings
    {
        public const string SettingsFileName = "AppSettings.config";

        [SettingCategory("Localization")]
        public string Language { get; set; }
        [SettingCategory("Window")]
        public double WindowPositionX { get; set; }
        public double WindowPositionY { get; set; }
        public int WindowState { get; set; }
        public double WindowWidth { get; set; }
        public double WindowHeight { get; set; }
        [SettingCategory("Feed")]
        public int PostsType { get; set; }
        [SettingCategory("Comments")]
        public int CommentReplyMode { get; set; }
        [SettingCategory("SpecialEvents")]
        public bool ChristmasEventEnabled { get; set; }
        public double BgmVolume { get; set; }
        [SettingCategory("Log")]
        public int LogRetentionDaysPeriod { get; set; }



        [ExcludedSetting]
        public WindowState WindowStateEnum
        {
            get
            {
                if (Enum.GetName(typeof(WindowState), WindowState) == null)
                    WindowState = (int)System.Windows.WindowState.Normal;

                return (WindowState)WindowState;
            }
            set
            {
                WindowState = (int)value;
            }
        }

        public AppSettings()
            : base(Path.Combine(Environment.ExecProcessDirectoryName, SettingsFileName))
        {
            Language = "en-US";
            WindowPositionX = SystemParameters.PrimaryScreenWidth / 2.0;
            WindowPositionY = SystemParameters.PrimaryScreenHeight / 2.0;
            WindowState = (int)System.Windows.WindowState.Normal;
            WindowWidth = 900;
            WindowHeight = 550;
            CommentReplyMode = (int)CommentReplyModeType.Legacy;
            ChristmasEventEnabled = true;
            BgmVolume = 0.5;
            LogRetentionDaysPeriod = 7;

            Load();
        }
    }
}
