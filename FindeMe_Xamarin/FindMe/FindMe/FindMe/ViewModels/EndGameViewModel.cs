//using CoreLocation;
using FindMe.Helpers;
using FindMe.Models;
using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FindMe.ViewModels
{
    class EndGameViewModel
    {
        private ScoresDataAccess sda = new ScoresDataAccess();
        private double _score;

        public EndGameViewModel(double score)
        {
            _score = score;
        }
        /// <summary>
        /// Ajoute le score dans la base de donnée
        /// </summary>
        public async void AddScore()
        {
            if(Device.OS != TargetPlatform.Windows)
            {
                var locator = CrossGeolocator.Current;
                locator.DesiredAccuracy = 50;

                var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);
                string coord = position.Latitude + " ; " + position.Longitude;
                Score score = new Score(Settings.UsernameSettings, _score, Settings.IsHardSettings, Settings.NbrIconSettings, Settings.TypeGameSettings, coord);
                sda.InsertUpdateData(score);
            }
            else
            {
                Score score = new Score(Settings.UsernameSettings, _score, Settings.IsHardSettings, Settings.NbrIconSettings, Settings.TypeGameSettings);
                sda.InsertUpdateData(score);
            }
            
        }

        public string LoadFact()
        {
            Random rnd = new Random();
            int i = rnd.Next(Facts.UKnow.Count);
            return Facts.UKnow[i];
        }

        public string isNewHightScore()
        {

            Score s;
            List<DataScore> listDataScores = sda.GetScoreGameMode(Settings.TypeGameSettings, Settings.IsHardSettings, Settings.NbrIconSettings);
            List<Score> listScores = new List<Score>();

            //Conversion de List<DataScore> en List<Score>
            for (int j = 0; j < listDataScores.Count; j++)
            {
                s = new Score(listDataScores[j]);
                listScores.Add(s);
            }

            //Tri du tableau de Scores
            listScores.Sort();

            //Condition d'apparaition du message de depassement du meilleur score
            if (listScores.Count > 0 && _score > listScores[0].ValueScore)
            {
                return "Bravo ! Vous avez établi le meilleur score !";
            }
            else
            {
                return "Vous pouvez mieux faire... :'(";
            }
        }
    }
}
