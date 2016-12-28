using System;
using System.Collections.Generic;
using System.Linq;
using FindMe.Helpers;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace FindMe.Helpers
{
    class ScoresDataAccess
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();
        
        public ScoresDataAccess()
        {
            database = DependencyService.Get<IDatabaseConnection>().DbConnection();
            database.CreateTable<DataScore>();
            this.Scores = new ObservableCollection<DataScore>(database.Table<DataScore>());

            if (!database.Table<DataScore>().Any())
            {
                AddNewScore();
            }
        }
        
        public ObservableCollection<DataScore> Scores { get; set; }

        public void AddNewScore()
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
    }
}
