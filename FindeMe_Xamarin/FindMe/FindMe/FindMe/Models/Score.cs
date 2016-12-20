using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMe.Models
{
    public class Score : IComparable
    {
         String username;
         double valueScore;
         bool isHard;
         int nbrIcons;
         String gameMode;
 
         public Score()
         {
             this.Username = "Guest";
             this.ValueScore = 0;
             this.IsHard = false;
             this.NbrIcons = 3;
             this.GameMode = "Doctor Who";
         }
 
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
