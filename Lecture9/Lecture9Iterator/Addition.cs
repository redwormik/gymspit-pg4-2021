using System;


namespace Lecture9Iterator
{
	class Addition: BinaryOperation
	{
		public Addition(Expression left, Expression right): base(left, right)
		{
		}


		protected override int Compute(int left, int right)
		{
			return left + right;
		}
	}
}
