using System;


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


		static void Main(string[] args)
		{
			City praha = new City("Praha");
			City brno = new City("Brno");
			City bratislava = new City("Bratislava");

			praha.AddHighway(brno, 200);
			brno.AddHighway(bratislava, 100);

			PrintHighways(praha);
			PrintHighways(brno);
			PrintHighways(bratislava);

			Console.WriteLine("Press any key to quit...");
			Console.ReadKey();
		}
	}
}
