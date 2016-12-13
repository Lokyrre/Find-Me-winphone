// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace FindMe.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
        private static ISettings AppSettings
        {
          get
          {
            return CrossSettings.Current;
          }
        }

        #region Setting Constants

        private const string UsernameKey = "username_key";
        private static readonly string UsernameDefault = "Guest";

        private const string IsHardKey = "isHard_key";
        private static readonly bool IsHardDefault = false;

        private const string NbrIconKey = "nbrIcon_Key";
        private static readonly int NbrIconDefault = 5;

        private const string HighScoreKey = "highScore_Key";
        private static readonly double HighScoreDefault = 0;

        #endregion


        public static string UsernameSettings
        {
          get
          {
            return AppSettings.GetValueOrDefault<string>(UsernameKey, UsernameDefault);
          }
          set
          {
            AppSettings.AddOrUpdateValue<string>(UsernameKey, value);
          }
        }

        public static bool IsHardSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<bool>(IsHardKey, IsHardDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<bool>(IsHardKey, value);
            }
        }

        public static int nbrIconSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<int>(NbrIconKey, NbrIconDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<int>(NbrIconKey, value);
            }
        }

        public static double HighScoreSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<double>(HighScoreKey, HighScoreDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<double>(HighScoreKey, value);
            }
        }

    }
}