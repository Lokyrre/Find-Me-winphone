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

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
                
        public LeaderboardViewModel(String typeGame = "Doctor Who", Boolean isHard = false, int nbrIcons = 3)
        {
            ScoresDataAccess sda = new ScoresDataAccess();
            Score s;
            List<DataScore> listTemp = new List<DataScore>();
            List<Score> listScore = new List<Score>();

            listTemp = sda.GetScoreGameMode(typeGame, isHard, nbrIcons);

            for (int i = 0; i < listTemp.Count; i++)
            {
                s = new Score(listTemp[i]);
                listScore.Add(s);
            }
            listScore.Sort();
            ListItems = new ObservableCollection<Score>(listScore);
        }
    }
}
