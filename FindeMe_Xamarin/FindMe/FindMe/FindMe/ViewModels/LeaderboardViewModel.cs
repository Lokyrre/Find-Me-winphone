using FindMe.Helpers;
using FindMe.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace FindMe.ViewModels
{
    class LeaderboardViewModel : INotifyPropertyChanged
    {
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
        
        /// <summary>
        /// Affiche la liste des scores
        /// </summary>
        /// <param name="typeGame">Le type de jeux par défaut c'est Doctor Who</param>
        /// <param name="isHard">La difficulté par défaut c'est false</param>
        /// <param name="nbrIcons">Le nombre d'icones par défaut c'est 3</param>                   
        public LeaderboardViewModel(String typeGame = "Doctor Who", Boolean isHard = false, int nbrIcons = 3)
        {
            ScoresDataAccess sda = new ScoresDataAccess();
            Score s;
            List<DataScore> listTemp = new List<DataScore>();
            List<Score> listScore = new List<Score>();

            listTemp = sda.GetScoreGameMode(typeGame, isHard, nbrIcons);

            //Convertion de List<DataScore> en List<Score>
            for (int i = 0; i < listTemp.Count; i++)
            {
                s = new Score(listTemp[i]);
                listScore.Add(s);
            }

            //Tri de la liste
            listScore.Sort();
            ListItems = new ObservableCollection<Score>(listScore);
        }
    }
}
