using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System.Collections.Generic;
using FindMe.Models;

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

        private const string NbrIconIndexKey = "nbrIconIndex_Key";
        private static readonly int NbrIconIndexDefault = 0;

        private const string NbrIconKey = "nbrIcon_Key";
        private static readonly int NbrIconDefault = 5;

        private const string HighScoresKey = "highScores_Key";
        private static readonly List<Score> HighScoresDefault = new List<Score>();
       
        private const string IsVibrationEnabledKey = "isVibrationEnabledKey";
        private static readonly bool IsVibrationEnabledDefault = true;

        private const string ListImageKey = "listImageKey";
        private static readonly Dictionary<string, List<string>> ListImageDefault = new Dictionary<string, List<string>>();

        private const string TypeGameKey = "TypeGeme_Key";
        private static readonly string TypeGameDefault = "Doctor Who";

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

        public static int NbrIconIndexSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<int>(NbrIconIndexKey, NbrIconIndexDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<int>(NbrIconIndexKey, value);
            }
        }

        public static int NbrIconSettings
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

        public static List<Score> HighScoresSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<List<Score>>(HighScoresKey, HighScoresDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<List<Score>>(HighScoresKey, value);
            }
        }
        
        public static bool IsVibrationEnabledSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<bool>(IsVibrationEnabledKey, IsVibrationEnabledDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<bool>(IsVibrationEnabledKey, value);
            }
        }

        public static string TypeGameSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(TypeGameKey, TypeGameDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(TypeGameKey, value);
            }
        }

        public static Dictionary<string, List<string>> ListImageSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<Dictionary<string, List<string>>>(ListImageKey, ListImageDefault);
            }
            set
            {

            }
        }
    }
}