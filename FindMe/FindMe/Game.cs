using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace FindMe
{
    public class Game
    {
        private List<Image> itemsTrue  = new List<Image>();
        private List<Image> itemsFalse = new List<Image>();

        public Image getItem(Boolean b,int i)
        {
            if (b)
            {
                return itemsTrue[i];
            }
            else
            {
                return itemsFalse[i];
            }
        }

        public void addItem(Boolean b,string path)
        {
            Uri imageUri = new Uri("pack://application:/Images/"+path, UriKind.RelativeOrAbsolute);
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            Image i = new Image();
            i.Source = imageBitmap;
            if(b)
            {
                itemsTrue.Add(i);
            }
            else
            {
                itemsFalse.Add(i);
            }
        }
    }
}