using System;


namespace Lecture9Visitor
{
	class Multiplication: BinaryOperation
	{
		public Multiplication(Expression left, Expression right): base(left, right)
		{
		}


		public override void Accept(ExpressionVisitor visitor)
		{
			visitor.VisitMultiplication(this);
		}


		protected override int Compute(int left, int right)
		{
			return left * right;
		}
	}
}
