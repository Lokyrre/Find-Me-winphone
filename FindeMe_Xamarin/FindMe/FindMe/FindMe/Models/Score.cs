using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMe.Models
{
    public class Score
    {
        public String Username { get; set; }
        public double ValueScore { get; set; }
        public bool IsHard { get; set; }
        public int NbrIcons { get; set; }
        public string GameMode { get; set; }
        
    }
}
