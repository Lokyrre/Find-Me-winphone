using FindMe.Helpers;
using System;

namespace FindMe.Models
{
    public class Score : IComparable
    {
        String username;
        double valueScore;
        bool isHard;
        int nbrIcons;
        String gameMode;
 
        /// <summary>
        /// Initialise Score avec les valeur Username = "Guest", ValueScore = 0, IsHard = false, NbrIcons = 3 et GameMode = "Doctor Who"
        /// </summary>
        public Score()
        {
            this.Username = "Guest";
            this.ValueScore = 0;
            this.IsHard = false;
            this.NbrIcons = 3;
            this.GameMode = "Doctor Who";
        }

        /// <summary>
        /// Initilise un Score avec les valeurs du DataScore
        /// </summary>
        /// <param name="ds">DataScore</param>
        public Score(DataScore ds)
        {
            Username = ds.Username;
            ValueScore = ds.ValueScore;
            IsHard = ds.IsHard;
            NbrIcons = ds.NbrIcons;
            GameMode = ds.GameMode;
        }

        /// <summary>
        /// Initialise un score
        /// </summary>
        /// <param name="username">Le nom de l'utilisateur</param>
        /// <param name="valueScore">Le score de l'utilisateur</param>
        /// <param name="isHard">La difficulté de la partie</param>
        /// <param name="nbrIcons">Le nombre d'icones de la partie</param>
        /// <param name="gameMode">Le type de jeu</param>
        public Score(String username, double valueScore, bool isHard, int nbrIcons, String gameMode)
        {
            this.Username = username;
            this.ValueScore = valueScore;
            this.IsHard = isHard;
            this.NbrIcons = nbrIcons;
            this.GameMode = gameMode;
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
 
         public double ValueScore
         {
            get { return valueScore; }
            set { valueScore = value; }
         }
 
         public bool IsHard
         {
             get { return isHard; }
             set { isHard = value; }
         }
 
         public int NbrIcons
         {
             get { return nbrIcons; }
             set { nbrIcons = value; }
         }
 
         public string GameMode
         {
             get { return gameMode; }
             set { gameMode = value; }
         }
 
         public int CompareTo(object obj)
         {
             return ((Score)obj).ValueScore.CompareTo(this.ValueScore);
         }
      }
}
