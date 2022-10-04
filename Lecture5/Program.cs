using System;

// https://learn.microsoft.com/en-us/dotnet/csharp/methods

namespace Lecture5
{
	class Program
	{
		static int Length(int number)
		{
			if (number == 0) {
				return 1;
			}

			if (number < 0) {
				return Length(-number) + 1;
			}

			return (int) Math.Log10(number) + 1;
		}


		static int Length(string str)
		{
			return str.Length;
		}


		/*
		static string Length(string str)
		{
			return str;
		}
		*/


		static int Length<T>(T[] array)
		{
			return array.Length;
		}


		static int Length(Parent parent)
		{
			parent.test();
			return Length("Parent");
		}


		static int Length(Child child)
		{
			child.test();
			return Length("Child");
		}


		static void Main(string[] args)
		{
			Console.WriteLine("Length(0) = {0}", Length(0));
			Console.WriteLine("Length(1) = {0}", Length(1));
			Console.WriteLine("Length(-1) = {0}", Length(-1));
			Console.WriteLine("Length(5) = {0}", Length(5));
			Console.WriteLine("Length(-5) = {0}", Length(-5));
			Console.WriteLine("Length(10) = {0}", Length(10));
			Console.WriteLine("Length(-10) = {0}", Length(-10));
			Console.WriteLine("Length(50) = {0}", Length(50));
			Console.WriteLine("Length(-50) = {0}", Length(-50));
			Console.WriteLine("Length(10000) = {0}", Length(10000));
			Console.WriteLine("Length(-10000) = {0}", Length(-10000));
			Console.WriteLine("Length(\"50000\") = {0}", Length("50000"));
			Console.WriteLine("Length(\"-50000\") = {0}", Length("-50000"));
			Console.WriteLine("Length(\"ahoj\") = {0}", Length("ahoj"));
			Console.WriteLine("Length(\"Length\") = {0}", Length("Length"));

			Console.WriteLine("Length(new int[] {{ 4, 42, 24 }}) = {0}", Length(new int[] { 4, 42, 24 }));

			Console.WriteLine("Length(new Parent()) = {0}", Length(new Parent()));
			Console.WriteLine("Length(new Child()) = {0}", Length(new Child()));

			var list = new Parent[] {
				new Parent(),
				new Child(),
			};
			foreach (var obj in list) {
				Console.WriteLine("Length(obj) = {0}", Length(obj));
			}

			Console.WriteLine("5 / 1 = {0}", new Fraction(5));
			Console.WriteLine("5 / 3 = {0}", new Fraction(5, 3));
			Console.WriteLine("5 / 3 + 1 / 2 = {0}", new Fraction(5, 3) + new Fraction(1, 2));
			Console.WriteLine("5 / 4 + 1 / 6 = {0}", new Fraction(5, 4) + new Fraction(1, 6));
			Console.WriteLine("5 / 4 + 1 / 4 = {0}", new Fraction(5, 4) + new Fraction(1, 4));
			Console.WriteLine("5 / 3 + 1 / 3 = {0}", new Fraction(5, 3) + new Fraction(1, 3));

			Console.WriteLine("5 / 3 + 3 = {0}", new Fraction(5, 3) + 3);
			Console.WriteLine("3 + 5 / 3 = {0}", 3 + new Fraction(5, 3));
			Console.WriteLine("5 / 3 - 3 = {0}", new Fraction(5, 3) - 3);
			Console.WriteLine("5 / 3 * 3 = {0}", new Fraction(5, 3) * 3);
			Console.WriteLine("5 / 3 / 3 = {0}", new Fraction(5, 3) / 3);

			Console.WriteLine((int) new Fraction(22, 7));

			Console.WriteLine("==");
			Console.WriteLine("5 / 3 == 10 / 6: {0}", new Fraction(5, 3) == new Fraction(10, 6));
			Console.WriteLine("5 / 3 == 11 / 6: {0}", new Fraction(5, 3) == new Fraction(11, 6));
			Console.WriteLine("8 / 4 == 2: {0}", new Fraction(8, 4) == 2);
			Console.WriteLine("8 / 4 == 3: {0}", new Fraction(8, 4) == 3);

			Console.WriteLine("!=");
			Console.WriteLine("5 / 3 != 10 / 6: {0}", new Fraction(5, 3) != new Fraction(10, 6));
			Console.WriteLine("5 / 3 != 11 / 6: {0}", new Fraction(5, 3) != new Fraction(11, 6));
			Console.WriteLine("8 / 4 != 2: {0}", new Fraction(8, 4) != 2);
			Console.WriteLine("8 / 4 != 3: {0}", new Fraction(8, 4) != 3);

			Console.WriteLine(">");
			Console.WriteLine("5 / 3 > 11 / 7: {0}", new Fraction(5, 3) > new Fraction(11, 7));
			Console.WriteLine("5 / 3 > 12 / 7: {0}", new Fraction(5, 3) > new Fraction(12, 7));
			Console.WriteLine("5 / 3 > 1: {0}", new Fraction(5, 3) > 1);
			Console.WriteLine("5 / 3 > 2: {0}", new Fraction(5, 3) > 2);
			Console.WriteLine("5 / 3 > 10 / 6: {0}", new Fraction(5, 3) > new Fraction(10, 6));
			Console.WriteLine("8 / 4 > 2: {0}", new Fraction(8, 4) > 2);

			Console.WriteLine("<");
			Console.WriteLine("5 / 3 < 11 / 7: {0}", new Fraction(5, 3) < new Fraction(11, 7));
			Console.WriteLine("5 / 3 < 12 / 7: {0}", new Fraction(5, 3) < new Fraction(12, 7));
			Console.WriteLine("5 / 3 < 1: {0}", new Fraction(5, 3) < 1);
			Console.WriteLine("5 / 3 < 2: {0}", new Fraction(5, 3) < 2);
			Console.WriteLine("5 / 3 < 10 / 6: {0}", new Fraction(5, 3) < new Fraction(10, 6));
			Console.WriteLine("8 / 4 < 2: {0}", new Fraction(8, 4) < 2);

			Console.WriteLine(">=");
			Console.WriteLine("5 / 3 >= 11 / 7: {0}", new Fraction(5, 3) >= new Fraction(11, 7));
			Console.WriteLine("5 / 3 >= 12 / 7: {0}", new Fraction(5, 3) >= new Fraction(12, 7));
			Console.WriteLine("5 / 3 >= 1: {0}", new Fraction(5, 3) >= 1);
			Console.WriteLine("5 / 3 >= 2: {0}", new Fraction(5, 3) >= 2);
			Console.WriteLine("5 / 3 >= 10 / 6: {0}", new Fraction(5, 3) >= new Fraction(10, 6));
			Console.WriteLine("8 / 4 >= 2: {0}", new Fraction(8, 4) >= 2);

			Console.WriteLine("<=");
			Console.WriteLine("5 / 3 <= 11 / 7: {0}", new Fraction(5, 3) <= new Fraction(11, 7));
			Console.WriteLine("5 / 3 <= 12 / 7: {0}", new Fraction(5, 3) <= new Fraction(12, 7));
			Console.WriteLine("5 / 3 <= 1: {0}", new Fraction(5, 3) <= 1);
			Console.WriteLine("5 / 3 <= 2: {0}", new Fraction(5, 3) <= 2);
			Console.WriteLine("5 / 3 <= 10 / 6: {0}", new Fraction(5, 3) <= new Fraction(10, 6));
			Console.WriteLine("8 / 4 <= 2: {0}", new Fraction(8, 4) <= 2);

			Console.ReadKey();
		}
	}
}
