using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMe.Models;
using System.Collections.ObjectModel;

namespace FindMe.ViewModels
{
    class HomeViewModel
    {
        public ObservableCollection<GameType> GameTypes { get; set; }

        public HomeViewModel()
        {
            GameTypes = new ObservableCollection<GameType>
            {
                new GameType
                {
                    ImageUrl = "",
                    Name = "Doctor Who"
                },

                new GameType
                {
                    ImageUrl = "",
                    Name = "My Little Poney"
                },

                new GameType
                {
                    ImageUrl = "",
                    Name = "Pokemon"
                }
            };
        }
    }
}
