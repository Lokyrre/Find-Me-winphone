using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.ComponentModel;
using SQLite.Net.Attributes;
using FindMe.Models;

namespace FindMe.Helpers
{
    public class DataScore
    {
        //Constructeur
        public DataScore()
        {
            Username = "Guest";
            ValueScore = 0;
            IsHard = false;
            NbrIcons = 3;
            GameMode = "Doctor Who";
        }

        //COnstructeur permettant de convertir un Score en DataScore
        public DataScore(Score s)
        {
            Username = s.Username;
            ValueScore = s.ValueScore;
            IsHard = s.IsHard;
            NbrIcons = s.NbrIcons;
            GameMode = s.GameMode;
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
