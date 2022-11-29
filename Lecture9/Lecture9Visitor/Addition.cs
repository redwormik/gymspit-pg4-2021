using System;


namespace Lecture9Visitor
{
	class Addition: BinaryOperation
	{
		public Addition(Expression left, Expression right): base(left, right)
		{
		}


		public override void Accept(ExpressionVisitor visitor)
		{
			visitor.VisitAddition(this);
		}


		protected override int Compute(int left, int right)
		{
			return left + right;
		}
	}
}
