using FindMe.Helpers;
using System;

namespace FindMe.ViewModels
{
    class GameViewModel
    {
        /// <summary>
        /// Créé la liste des icones
        /// </summary>
        public GameViewModel()
        {
            Icon.IconList();
        }

        /// <summary>
        /// Selectionne un item aléatoir dans la liste
        /// </summary>
        /// <param name="isWhiteIntruder">L'intru doit apartenir a la liste blance</param>
        /// <param name="intruder">Selection un intru</param>
        /// <returns>Un item</returns>
        public string Item(bool isWhiteIntruder,bool intruder)
        {
            Random r = new Random();
            string gameWhite = Settings.TypeGameSettings + "White";
            string gameBlack = Settings.TypeGameSettings + "Black";

            // Prends un nombre aléatoir entre 0 et la taille de la liste - 1
            int indexWhite = r.Next(Settings.ListImageSettings[gameWhite].Count);
            int indexBlack = r.Next(Settings.ListImageSettings[gameWhite].Count);

            string item;

            // Selectionne l'item celon la liste intru et si c'est un intru
            if(isWhiteIntruder)
            {
                if(intruder)
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
