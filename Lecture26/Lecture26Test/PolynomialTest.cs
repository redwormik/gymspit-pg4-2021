using Lecture26;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace Lecture26Test
{
	[TestClass]
	public class PolynomialTest
	{
		[TestMethod]
		public void TestDegree()
		{
			Polynomial polynomial = new Polynomial(3, new double[]{ 1, 3, 3, 1 });
			Assert.AreEqual(3, polynomial.Degree);
		}


		[TestMethod]
		public void TestCoeficient()
		{
			Polynomial polynomial = new Polynomial(3, new double[] { 1, -3, 3, -1 });
			Assert.AreEqual(1, polynomial.Coeficient(3));
			Assert.AreEqual(-3, polynomial.Coeficient(2));
			Assert.AreEqual(3, polynomial.Coeficient(1));
			Assert.AreEqual(-1, polynomial.Coeficient(0));
		}


		[TestMethod]
		public void TestHighestCoeficientNotZero()
		{
			Assert.ThrowsException<ArgumentException>(() => {
				new Polynomial(3, new double[] { 0, -3, 3, -1 });
			});
			Assert.ThrowsException<ArgumentException>(() => {
				new Polynomial(3, new double[] {});
			});

			Polynomial constant = new Polynomial(0, new double[] {});
			Assert.AreEqual(0, constant.Coeficient(0));

			Polynomial quartic = new Polynomial(4, new double[] { 0.00000001 });
			Assert.AreNotEqual(0, quartic.Coeficient(4));
			Assert.AreEqual(0, quartic.Coeficient(0));
		}


		[TestMethod]
		public void TestOperatorPlus()
		{
			Polynomial cubic = new Polynomial(3, new double[] { 1, -3, 3, -1 });
			Polynomial quadratic = new Polynomial(2, new double[] { 1, -2, 1 });

			object result = cubic + quadratic;
			Assert.IsInstanceOfType(result, typeof(Polynomial));
			Polynomial sum = result as Polynomial;

			Assert.AreEqual(3, sum.Degree);
			Assert.AreEqual(1, sum.Coeficient(3));
			Assert.AreEqual(-2, sum.Coeficient(2));
			Assert.AreEqual(1, sum.Coeficient(1));
			Assert.AreEqual(0, sum.Coeficient(0));
		}
	}
}
