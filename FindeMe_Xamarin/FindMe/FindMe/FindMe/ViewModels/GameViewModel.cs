using FindMe.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMe.ViewModels
{
    class GameViewModel
    {
        public GameViewModel()
        {
            Icon.IconList();
        }
        public string Item(bool isWhiteIntruder,bool intruder)
        {
            Random r = new Random();
            string gameWhite = Settings.TypeGameSettings + "White";
            string gameBlack = Settings.TypeGameSettings + "Black";
            int indexWhite = r.Next(Settings.ListImageSettings[gameWhite].Count);
            int indexBlack = r.Next(Settings.ListImageSettings[gameWhite].Count);
            string item;

            if (isWhiteIntruder)
            {
                if (intruder)
                {
                    item = Settings.ListImageSettings[gameWhite][indexWhite] + ".png";
                    Settings.ListImageSettings[gameWhite].Remove(Settings.ListImageSettings[gameWhite][indexWhite]);
                }
                else
                {
                    item = Settings.ListImageSettings[gameBlack][indexBlack] + ".png";
                    Settings.ListImageSettings[gameBlack].Remove(Settings.ListImageSettings[gameWhite][indexBlack]);
                }
            }
            else
            {
                if (intruder)
                {
                    item = Settings.ListImageSettings[gameBlack][indexBlack] + ".png";
                    Settings.ListImageSettings[gameBlack].Remove(Settings.ListImageSettings[gameWhite][indexWhite]);
                }
                else
                {
                    item = Settings.ListImageSettings[gameWhite][indexWhite] + ".png";
                    Settings.ListImageSettings[gameWhite].Remove(Settings.ListImageSettings[gameWhite][indexBlack]);
                }
            }

            return item;
        }

        public static void ClearListItem()
        {
            Settings.ListImageSettings.Clear();
        }
    }
}
