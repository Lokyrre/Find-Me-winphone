using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMe.Helpers;
using System.ComponentModel;

namespace FindMe.ViewModels
{
    class OptionsViewModel : INotifyPropertyChanged
    {
        private static bool hardGame;
        private static bool sound;
        private static bool vibration;
        private static int nbIconesIndex;
        private static int nbIcones;
        private static string username;

        public bool HardGame
        {
            get { return hardGame; }
            set
            {
                hardGame = value;
                Settings.IsHardSettings = hardGame;
                OnPropertyChanged("HardGame");
            }
        }

        public bool Sound
        {
            get
            {
                return sound;
            }

            set
            {
                sound = value;
                Settings.IsSongEnabledSettings = sound;
                OnPropertyChanged("Sound");
            }
        }

        public bool Vibration
        {
            get
            {
                return vibration;
            }

            set
            {
                vibration = value;
                Settings.IsVibrationEnabledSettings = vibration;
                OnPropertyChanged("Vibration");
            }
        }

        public int NbIconesIndex
        {
            get
            {
                return nbIconesIndex;
            }

            set
            {
                nbIconesIndex = value;
                Settings.nbrIconIndexSettings = nbIconesIndex;
                OnPropertyChanged("NbIconesIndex");
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
                Settings.UsernameSettings = username;
                OnPropertyChanged("Username");
            }
        }

        public int NbIcones
        {
            get
            {
                return nbIcones;
            }

            set
            {
                nbIcones = value;
                Settings.nbrIconSettings = nbIconesIndex;
                OnPropertyChanged("NbIcones");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public OptionsViewModel()
        {
            HardGame = Settings.IsHardSettings;
            Sound = Settings.IsSongEnabledSettings;
            Vibration = Settings.IsVibrationEnabledSettings;
            NbIconesIndex = Settings.nbrIconIndexSettings;
            NbIcones = Settings.nbrIconSettings;
            Username = Settings.UsernameSettings;
        }
    }
}
