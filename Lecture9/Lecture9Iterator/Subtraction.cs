using System;


namespace Lecture9Iterator
{
	class Subtraction : BinaryOperation
	{
		public Subtraction(Expression left, Expression right) : base(left, right)
		{
		}


		protected override int Compute(int left, int right)
		{
			return left - right;
		}
	}
}
