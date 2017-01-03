using FindMe.Helpers;
using System;
using System.Collections.Generic;

namespace FindMe
{
	public class Icon
	{
		private double relativeX;
		public double RelativeX
		{
			get { return relativeX; }
			set { relativeX = value; }
		}

		private double relativeY;
		public double RelativeY
		{
			get { return relativeY; }
			set { relativeY = value; }
		}

		private double relativeDim;
		public double RelativeDim
		{
			get { return relativeDim; }
			set { relativeDim = value; }
		}

		public Icon()
		{
			relativeX = 0;
			relativeY = 0;
			relativeDim = 0.1;
		}

		public Icon Copy()
		{
			Icon iconCopy = new Icon();
			iconCopy.RelativeDim = this.relativeDim;
			iconCopy.RelativeX = this.relativeX;
			iconCopy.RelativeY = this.relativeY;

			return iconCopy;
		}

		public bool IsSuperposed(Icon _icon)
		{
			throw new NotImplementedException("Vous devez implémenter la méthode Icon.isSuperposed() avant de l'utiliser");
		}
        
        /// <summary>
        /// Créé la liste des icones du jeu
        /// </summary>
        public static void IconList()
        {
            List<string> items = new List<string>();
            items.Add("dw1");
            items.Add("dw2");
            items.Add("dw3");
            items.Add("dw4");
            items.Add("dw5");
            items.Add("dw6");
            items.Add("dw7");
            App.ListImageSettings.Add("Doctor WhoWhite", items);

            items = new List<string>();
            items.Add("dwb1");
            items.Add("dwb2");
            items.Add("dwb3");
            items.Add("dwb4");
            items.Add("dwb5");
            items.Add("dwb6");
            items.Add("dwb7");
            App.ListImageSettings.Add("Doctor WhoBlack", items);

            items = new List<string>();
            items.Add("bmlp1");
            items.Add("bmlp2");
            items.Add("bmlp3");
            items.Add("bmlp4");
            items.Add("bmlp5");
            items.Add("bmlp6");
            items.Add("bmlp7");
            App.ListImageSettings.Add("My Little PonyWhite", items);

            items = new List<string>();
            items.Add("mlp1");
            items.Add("mlp2");
            items.Add("mlp3");
            items.Add("mlp4");
            items.Add("mlp5");
            items.Add("mlp6");
            items.Add("mlp7");
            App.ListImageSettings.Add("My Little PonyBlack", items);

            items = new List<string>();
            items.Add("epkm1");
            items.Add("epkm2");
            items.Add("epkm3");
            items.Add("epkm4");
            items.Add("epkm5");
            items.Add("epkm6");
            items.Add("epkm7");
            App.ListImageSettings.Add("PokemonWhite", items);

            items = new List<string>();
            items.Add("pkm1");
            items.Add("pkm2");
            items.Add("pkm3");
            items.Add("pkm4");
            items.Add("pkm5");
            items.Add("pkm6");
            items.Add("pkm7");
            App.ListImageSettings.Add("PokemonBlack", items);
        }
	}

}
