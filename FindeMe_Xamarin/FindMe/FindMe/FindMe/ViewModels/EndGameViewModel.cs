using FindMe.Helpers;
using FindMe.Models;
using System;
using System.Collections.Generic;

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
        public void AddScore()
        {
            Score score = new Score(Settings.UsernameSettings, _score, Settings.IsHardSettings, Settings.NbrIconSettings, Settings.TypeGameSettings);
            sda.InsertUpdateData(score);
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
                return "\n Bravo ! Vous avez établi le meilleur score !";
            }
            else
            {
                return "\n Vous pouvez mieux faire... :'(";
            }
        }
    }
}
