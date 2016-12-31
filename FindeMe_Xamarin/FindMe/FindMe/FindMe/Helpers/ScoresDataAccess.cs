using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using FindMe.Models;
using SQLite.Net;

namespace FindMe.Helpers
{
    class ScoresDataAccess
    {
        public ObservableCollection<DataScore> Scores { get; set; }
        /// <summary>
        /// Insert ou Update un DataScore
        /// </summary>
        /// <param name="data">Le DataScore à un inserer ou a update</param>
        /// <returns>L'état de la requête</returns>
        public string InsertUpdateData(DataScore data)
        {
            try
            {
                var dB = DependencyService.Get<IDatabaseConnection>().GetConnection();

                if (dB.Insert(data) != 0)
                    dB.Update(data);
                return "Single data file inserted or updated";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Insert ou Update un score
        /// </summary>
        /// <param name="s">Le score à un inserer ou a update</param>
        /// <returns>L'état de la requête</returns>
        public string InsertUpdateData(Score s)
        {
            try
            {
                DataScore data = new DataScore(s); // On caste le score en data score
                var dB = DependencyService.Get<IDatabaseConnection>().GetConnection();

                if (dB.Insert(data) != 0)
                    dB.Update(data);
                return "Single data file inserted or updated";
            }
            catch (SQLiteException ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        /// Récupère la liste des scores par mode de jeu, de difficulté et de nombres d'icones
        /// </summary>
        /// <param name="gameMode">Le type de jeu</param>
        /// <param name="isHard">La difficulté</param>
        /// <param name="nbrIcons">Le nombre d'icones</param>
        /// <returns>La liste des scores</returns>
        public List<DataScore> GetScoreGameMode(string gameMode, Boolean isHard, int nbrIcons)
        {
            try
            {
                var dB = DependencyService.Get<IDatabaseConnection>().GetConnection();
                var score = dB.Query<DataScore>("select * from DataScore where GameMode = ? and IsHard = ? and NbrIcons = ?", gameMode, isHard, nbrIcons);

                return score;
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }
    }
}
