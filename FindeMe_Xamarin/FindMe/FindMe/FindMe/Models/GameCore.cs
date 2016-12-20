using System;
using System.Collections.Generic;

namespace FindMe
{
	public class GameCore
	{
		private List<Icon> iconSet;

		public GameCore(List<Icon> _iconSet)
		{
			iconSet = _iconSet;
		}

		public void NewRound()
		{
			Random rand = new Random();
			List<Icon> iconsPositionned = new List<Icon>();
			foreach (Icon oneIcon in iconSet)
			{
				int currentLoop = 0;
				bool positionIsValid = false;

				while (!positionIsValid || currentLoop < 100000)
				{
					double x = rand.Next(1000);
					double y = rand.Next(1000);
					positionIsValid = true;

					foreach (var oneIconPositionned in iconsPositionned)
					{
						if (oneIconPositionned.IsSuperposed(oneIcon))
						{
							currentLoop++;
							positionIsValid = false;
							break;
						}
					}
					if (positionIsValid)
					{
						Icon iconToBeAdded = oneIcon.Copy();
						iconToBeAdded.RelativeX = x;
						iconToBeAdded.RelativeY = y;
						iconsPositionned.Add(iconToBeAdded);
					}
				}


			}
		}
	}


}
