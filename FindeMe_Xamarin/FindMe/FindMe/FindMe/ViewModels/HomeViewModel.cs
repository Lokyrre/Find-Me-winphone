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
        public ObservableCollection<GameMode> GameModes { get; set; }

        public HomeViewModel()
        {
            GameModes = new ObservableCollection<GameMode>
            {
                new GameMode
                {
                    ImageUrl = "doctorwho_logo.png",
                    Name = "Doctor Who"
                },

                new GameMode
                {
                    ImageUrl = "mlp_logo.png",
                    Name = "My Little Pony"
                },

                new GameMode
                {
                    ImageUrl = "pkm_logo.png",
                    Name = "Pokemon"
                }
            };
        }
    }
}
