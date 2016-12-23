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
            if (TypeScore == 0)
            {

            }

            else if (TypeScore == 1)
            {

            }

            else
            {

            }
            Settings.HighScoresSettings.Sort();
            ListItems = new ObservableCollection<Score>(Settings.HighScoresSettings);
        }
    }
}
