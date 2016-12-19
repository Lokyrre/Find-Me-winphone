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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public OptionsViewModel()
        {
            HardGame = Settings.IsHardSettings;
        }
    }
}
