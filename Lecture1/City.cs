using System;
using System.Collections.Generic;


namespace Lecture1
{
	class City
	{
		public string Name { get; private set; }
		private IList<Highway> highways = new List<Highway>();


		public City(string name)
		{
			Name = name;
		}


		public IEnumerable<Highway> GetHighways()
		{
			foreach (Highway highway in highways)
			{
				yield return highway;
			}
		}


		public void AddHighway(City otherCity, int length)
		{
			Highway highway = new Highway(this, otherCity, length);
			highways.Add(highway);
			if (otherCity != this) {
				otherCity.highways.Add(highway);
			}
		}
	}
}