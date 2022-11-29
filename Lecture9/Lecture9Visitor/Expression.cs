using System;
using System.Collections.Generic;


namespace Lecture9Visitor
{
	interface Expression : IEnumerable<Expression>
	{
		int GetValue();
		void Accept(ExpressionVisitor visitor);
	}
}
