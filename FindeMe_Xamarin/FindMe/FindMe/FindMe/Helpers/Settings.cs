// Helpers/Settings.cs
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

        private const string NbrIconKey = "nbrIcon_Key";
        private static readonly int NbrIconDefault = 5;

        private const string HighScoresKey = "highScores_Key";
        private static readonly List<Score> HighScoresDefault = new List<Score>
        {
            new Score
            {
                GameMode = "Doctor Who",
                IsHard = false,
                NbrIcons = 5,
                Username = "Toto",
                ValueScore = 6358
            },
            new Score
            {
                GameMode = "Doctor Who",
                IsHard = false,
                NbrIcons = 5,
                Username = "Tata",
                ValueScore = 352
            }
        };

        private const string IsSongEnabledKey = "isSongEnabled_key";
        private static readonly bool IsSongEnabledDefault = true;

        private const string IsVibrationEnabledKey = "isHard_key";
        private static readonly bool IsVibrationEnabledDefault = true;

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

        public static bool IsSongEnabledSettings
        {
            get
            {
                return AppSettings.GetValueOrDefault<bool>(IsSongEnabledKey, IsSongEnabledDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<bool>(IsSongEnabledKey, value);
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

    }
}