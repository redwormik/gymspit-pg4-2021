using System;


namespace Lecture1
{
	class Highway
	{
		public City From { get; private set; }
		public City To { get; private set; }
		public int Length { get; private set; }


		public Highway(City from, City to, int length)
		{
			this.From = from;
			this.To = to;
			this.Length = length;
		}


		public City OtherEnd(City city)
		{
			if (city == From) {
				return To;
			} else if (city == To) {
				return From;
			} else {
				throw new ArgumentException();
			}
		}
	}
}
