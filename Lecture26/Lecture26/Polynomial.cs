using System;


namespace Lecture26
{
	public class Polynomial
	{
		public int Degree { get; private set; }

		private readonly double[] coeficients;


		public Polynomial(int degree, double[] coeficients)
		{
			if (degree < 0) {
				throw new ArgumentOutOfRangeException();
			}

			Degree = degree;

			if (Degree > 0 && (coeficients.Length == 0 || coeficients[0] == 0)) {
				throw new ArgumentException();
			}

			this.coeficients = new double[Degree + 1];
			for (int i = 0; i <= Degree && i < coeficients.Length; i += 1) {
				this.coeficients[i] = coeficients[i];
			}
		}


		public double Coeficient(int degree)
		{
			if (degree < 0 || degree > Degree) {
				throw new ArgumentOutOfRangeException();
			}

			return coeficients[Degree - degree];
		}


		public static Polynomial operator+(Polynomial a, Polynomial b)
		{
			int degree = Math.Max(a.Degree, b.Degree);
			double[] coeficients = new double[degree + 1];

			for (int i = 0; i <= degree; i += 1) {
				coeficients[i] = (degree <= a.Degree ? a.Coeficient(a.Degree - i) : 0) +
					(degree <= b.Degree ? b.Coeficient(b.Degree - i) : 0);
			}

			return new Polynomial(degree, coeficients);
		}
	}
}
