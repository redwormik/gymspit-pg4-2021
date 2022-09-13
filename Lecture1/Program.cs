using System;
using System.Collections.Generic;


namespace Lecture1
{
	class Program
	{
		static void PrintHighways(City city)
		{
			Console.WriteLine("{0}:", city.Name);
			foreach (Highway highway in city.GetHighways()) {
				Console.WriteLine("\t{0} ({1} km):", highway.OtherEnd(city).Name, highway.Length);
			}
			Console.WriteLine();
		}


		static bool Neighbors(City city, City destination)
		{
			foreach (Highway highway in city.GetHighways()) {
				if (highway.OtherEnd(city) == destination) {
					return true;
				}
			}

			return false;
		}

		static bool Connected(City city, City destination)
		{
			ISet<City> visited = new HashSet<City>();
			return Connected(city, destination, visited);
		}


		static bool Connected(City city, City destination, ISet<City> visited)
		{
			if (city == destination) {
				return true;
			}

			visited.Add(city);

			foreach (Highway highway in city.GetHighways()) {
				City neighbor = highway.OtherEnd(city);
				if (visited.Contains(neighbor)) {
					continue;
				}

				if (Connected(neighbor, destination, visited)) {
					return true;
				}
			}

			return false;
		}


		static int? ShortestPath(City city, City destination, out IList<City> path)
		{
			ISet<City> visited = new HashSet<City>();
			path = new List<City>();
			path.Add(city);
			return ShortestPath(city, destination, visited, ref path);
		}


		static int? ShortestPath(City city, City destination, ISet<City> visited, ref IList<City> path)
		{
			if (city == destination) {
				return 0;
			}

			visited.Add(city);
			IList<City> shortestPath = null;
			int? shortestLength = null;

			foreach (Highway highway in city.GetHighways())
			{
				City neighbor = highway.OtherEnd(city);

				if (visited.Contains(neighbor))
				{
					continue;
				}

				IList<City> neighborPath = new List<City>(path);
				neighborPath.Add(neighbor);
				int? neighborLength = ShortestPath(neighbor, destination, visited, ref neighborPath);

				if (neighborLength != null) {
					neighborLength += highway.Length;
					if (shortestLength == null || neighborLength < shortestLength) {
						shortestPath = neighborPath;
						shortestLength = neighborLength;
					}
				}
			}

			path = shortestPath;
			return shortestLength;
		}

		static void PrintPath(City city, City destination)
		{
			IList<City> path;
			int? length = ShortestPath(city, destination, out path);
			if (length == null) {
				Console.WriteLine("ShortestPath({0}, {1}) = N/A", city.Name, destination.Name);
				return;
			}

			Console.WriteLine("ShortestPath({0}, {1}) = {2}", city.Name, destination.Name, length);
			foreach (City waypoint in path) {
				Console.WriteLine("\t{0}", waypoint.Name);
			}
		}


		static void Main(string[] args)
		{
			City praha = new City("Praha");
			City plzen = new City("Plzeň");
			City liberec = new City("Liberec");
			City brno = new City("Brno");
			City bratislava = new City("Bratislava");

			City newYork = new City("New York");
			City newJersey = new City("New Jersey");
			City lasVegas = new City("Las Vegas");
			City losAngeles = new City("Los Angeles");
			City sanFrancisco = new City("San Francisco");

			City anchorage = new City("Anchorage");

			// praha.AddHighway(praha, 50);
			praha.AddHighway(brno, 200);
			praha.AddHighway(plzen, 100);
			praha.AddHighway(liberec, 100);
			plzen.AddHighway(liberec, 150);
			brno.AddHighway(bratislava, 100);

			newYork.AddHighway(newJersey, 150);
			newYork.AddHighway(lasVegas, 1500);
			lasVegas.AddHighway(losAngeles, 500);
			lasVegas.AddHighway(sanFrancisco, 1000);
			losAngeles.AddHighway(sanFrancisco, 150);

			anchorage.AddHighway(anchorage, 10);

			PrintHighways(praha);
			PrintHighways(plzen);
			PrintHighways(liberec);
			PrintHighways(brno);
			PrintHighways(bratislava);
			PrintHighways(anchorage);

			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, praha.Name, Neighbors(praha, praha));
			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, brno.Name, Neighbors(praha, brno));
			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, plzen.Name, Neighbors(praha, plzen));
			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, liberec.Name, Neighbors(praha, liberec));
			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, bratislava.Name, Neighbors(praha, bratislava));

			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, newYork.Name, Neighbors(praha, newYork));
			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, newJersey.Name, Neighbors(praha, newJersey));
			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, lasVegas.Name, Neighbors(praha, lasVegas));
			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, losAngeles.Name, Neighbors(praha, losAngeles));
			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, sanFrancisco.Name, Neighbors(praha, sanFrancisco));
			Console.WriteLine("Neighbors({0}, {1}) = {2}", praha.Name, anchorage.Name, Neighbors(praha, anchorage));

			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, praha.Name, Connected(praha, praha));
			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, brno.Name, Connected(praha, brno));
			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, plzen.Name, Connected(praha, plzen));
			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, liberec.Name, Connected(praha, liberec));
			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, bratislava.Name, Connected(praha, bratislava));

			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, newYork.Name, Connected(praha, newYork));
			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, newJersey.Name, Connected(praha, newJersey));
			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, lasVegas.Name, Connected(praha, lasVegas));
			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, losAngeles.Name, Connected(praha, losAngeles));
			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, sanFrancisco.Name, Connected(praha, sanFrancisco));
			Console.WriteLine("Connected({0}, {1}) = {2}", praha.Name, anchorage.Name, Connected(praha, anchorage));

			Console.WriteLine("Connected({0}, {1}) = {2}", anchorage.Name, anchorage.Name, Connected(anchorage, anchorage));
			Console.WriteLine("Connected({0}, {1}) = {2}", anchorage.Name, praha.Name, Connected(anchorage, praha));

			PrintPath(praha, praha);
			PrintPath(praha, brno);
			PrintPath(praha, plzen);
			PrintPath(praha, liberec);
			PrintPath(praha, bratislava);

			PrintPath(praha, newYork);
			PrintPath(praha, newJersey);
			PrintPath(praha, lasVegas);
			PrintPath(praha, losAngeles);
			PrintPath(praha, sanFrancisco);
			PrintPath(praha, anchorage);

			PrintPath(plzen, liberec);

			PrintPath(anchorage, anchorage);
			PrintPath(anchorage, praha);

			Console.WriteLine("Press any key to quit...");
			Console.ReadKey();
		}
	}
}
