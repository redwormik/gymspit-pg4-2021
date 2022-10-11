using System;
using System.Collections.Generic;


namespace Lecture6
{
	class Program
	{
		static void Main(string[] args)
		{
			// DonutFactory factory = new DefaultDonutFactory("Vanilla", "Raspberry");
			DonutFactory factory = new RandomDonutFactory(
				new string[] { "Vanilla", "Chocolate", "Jam" },
				new string[] { "Raspberry", "Chocolate", "Sugar" }
			);

			// --------------------------------------------------------------------

			Donut donut = factory.CreateDonut();
			Donut otherDonut = factory.CreateDonut();

			Console.WriteLine("Donut has {0} filling and {1} glaze", donut.Filling, donut.Glaze);
			Console.WriteLine("Other donut has {0} filling and {1} glaze", otherDonut.Filling, otherDonut.Glaze);
			Console.WriteLine("donut == otherDonut: {0}", donut == otherDonut);


			donut = ToroidFood.CreateDonut("Banana", "None");
			Bagel bagel = ToroidFood.CreateBagel("Ham");

			Console.WriteLine("Donut has {0} filling and {1} glaze", donut.Filling, donut.Glaze);
			Console.WriteLine("Bagel has {0} flavor", bagel.Flavor);

			Company company = new Company("ACME");
			company.AddRegularEmployee("Wil. E. Coyote");
			company.AddRegularEmployee("Road Runner");

			foreach (Employee employee in company.Employees())
			{
				Console.WriteLine("{0} works at {1}", employee.Name, employee.Company.Name);
			}

			Console.WriteLine("Press any key to quit...");
			Console.ReadKey();
		}
	}
}
