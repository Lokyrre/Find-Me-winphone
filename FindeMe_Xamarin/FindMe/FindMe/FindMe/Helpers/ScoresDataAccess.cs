using System;
using System.Collections.Generic;
using System.Linq;
using FindMe.Helpers;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Async;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using FindMe.Models;
using SQLite.Net;
using SQLite.Net.Interop;

namespace FindMe.Helpers
{
    class ScoresDataAccess
    {
       public ObservableCollection<DataScore> Scores { get; set; }

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

        public string InsertUpdateData(Score s)
        {
            try
            {
                DataScore data = new DataScore(s);
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

        public List<DataScore> GetScoreGameMode(string gameMode)
        {
            try
            {
                var dB = DependencyService.Get<IDatabaseConnection>().GetConnection();
                var score = dB.Query<DataScore>("select * from DataScore where GameMode = ?", gameMode);

                return score;
            }
            catch (SQLiteException ex)
            {
                return null;
            }
        }

        /*public void AddNewScore()
        {
            this.Scores.
              Add(new DataScore
              {
                  Username = "Guest",
                  ValueScore = 0,
                  IsHard = false,
                  NbrIcons = 3,
                  GameMode = "Doctor Who"
              });
        }

        public void AddNewScore(String username, int valueScore, Boolean isHard, int nbrIcons, String gameMode)
        {
            this.Scores.
              Add(new DataScore
              {
                  Username = username,
                  ValueScore = valueScore,
                  IsHard = isHard,
                  NbrIcons = nbrIcons,
                  GameMode = gameMode
              });
        }

        public void AddNewScore(Score s)
        {
            this.Scores.
              Add(new DataScore
              {
                  Username = s.Username,
                  ValueScore = s.ValueScore,
                  IsHard = s.IsHard,
                  NbrIcons = s.NbrIcons,
                  GameMode = s.GameMode
              });
        }

        public IEnumerable<DataScore> GetFilteredScores(string gameMode)
        {
            lock (collisionLock)
            {
                var query = from cust in database.Table<DataScore>()
                            where cust.GameMode == gameMode
                            select cust;
                
                return query.AsEnumerable();
            }
        }

        public int DeleteScore(DataScore scoreInstance)
        {
            var id = scoreInstance.Id;
            if (id != 0)
            {
                lock (collisionLock)
                {
                    database.Delete<DataScore>(id);
                }
            }
            this.Scores.Remove(scoreInstance);
            return id;
        }*/
    }
}
