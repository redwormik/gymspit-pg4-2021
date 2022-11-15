using System;


namespace Lecture9Iterator
{
	class Division : BinaryOperation
	{
		public Division(Expression left, Expression right) : base(left, right)
		{
		}


		protected override int Compute(int left, int right)
		{
			return left / right;
		}
	}
}
