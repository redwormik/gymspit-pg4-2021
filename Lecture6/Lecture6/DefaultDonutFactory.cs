using System;


namespace Lecture6
{
	class DefaultDonutFactory: DonutFactory
	{
		private string filling;

		private string glaze;


		public DefaultDonutFactory(string filling, string glaze)
		{
			this.filling = filling;
			this.glaze = glaze;
		}

		
		public Donut CreateDonut()
		{
			return new Donut(filling, glaze);
		}
	}
}
