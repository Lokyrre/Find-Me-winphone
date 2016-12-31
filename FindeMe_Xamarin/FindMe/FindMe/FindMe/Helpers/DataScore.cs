using System;
using SQLite.Net.Attributes;
using FindMe.Models;

namespace FindMe.Helpers
{
    public class DataScore
    {
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public DataScore()
        {
            Username = "Guest";
            ValueScore = 0;
            IsHard = false;
            NbrIcons = 3;
            GameMode = "Doctor Who";
            Localisation = null;
        }
        
        /// <summary>
        /// Constructeur permettant de convertir un Score en DataScore
        /// </summary>
        /// <param name="s">Le score a convertire</param>
        public DataScore(Score s)
        {
            Username = s.Username;
            ValueScore = s.ValueScore;
            IsHard = s.IsHard;
            NbrIcons = s.NbrIcons;
            GameMode = s.GameMode;
            Localisation = s.Localisation;
        }

        //Contenu de la table DataScore de la base SQLite

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull]
        public string Username { get; set; }

        [NotNull]
        public double ValueScore { get; set; }

        [NotNull]
        public bool IsHard { get; set; }

        [NotNull]
        public int NbrIcons { get; set; }

        [NotNull]
        public String GameMode { get; set; }

        public String Localisation { get; set; }

    }
}
