using FindMe.Helpers;
using FindMe.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMe.ViewModels
{
    class LeaderboardViewModel : INotifyPropertyChanged
    {
        private int typeScore;
        private static ObservableCollection<Score> listItems = new ObservableCollection<Score>();
        public ObservableCollection<Score> ListItems
        {
            get { return listItems; }
            set
            {
                if (listItems != value)
                {
                    listItems = value;
                    OnPropertyChanged("ListItems");
                }
            }
        }

        public int TypeScore
        {
            get
            {
                return typeScore;
            }

            set
            {
                typeScore = value;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public LeaderboardViewModel()
        {
            List<Score> listGameMode = new List<Score>();
            Settings.HighScoresSettings.Sort();
            for(int i=0; i< Settings.HighScoresSettings.Count; i++)
            {
                if (TypeScore == 0 && Settings.HighScoresSettings[i].GameMode == "Doctor Who")
                {
                    listGameMode.Add(Settings.HighScoresSettings[i]);
                }

                else if (TypeScore == 1 && Settings.HighScoresSettings[i].GameMode == "My Little Poney")
                {
                    listGameMode.Add(Settings.HighScoresSettings[i]);
                }

                else
                {
                }
                ListItems = new ObservableCollection<Score>(listGameMode);
            }
        }
    }
}
