﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Lecture6Composite
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
