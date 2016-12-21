using System;

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
	}

}
