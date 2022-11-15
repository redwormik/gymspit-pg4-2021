using System;


namespace Lecture9Iterator
{
	class Multiplication: BinaryOperation
	{
		public Multiplication(Expression left, Expression right): base(left, right)
		{
		}


		protected override int Compute(int left, int right)
		{
			return left * right;
		}
	}
}
