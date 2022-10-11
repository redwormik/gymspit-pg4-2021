using System;


namespace Lecture6
{
	class ToroidFood
	{
		public static Bagel CreateBagel(string flavor)
		{
			return new Bagel(flavor);
		}


		public static Donut CreateDonut(string filling, string glaze)
		{
			return new Donut(filling, glaze);
		}
	}
}
