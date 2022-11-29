using System;


namespace Lecture9Visitor
{
	class Subtraction: BinaryOperation
	{
		public Subtraction(Expression left, Expression right): base(left, right)
		{
		}


		public override void Accept(ExpressionVisitor visitor)
		{
			visitor.VisitSubtraction(this);
		}


		protected override int Compute(int left, int right)
		{
			return left - right;
		}
	}
}
