﻿using System;
using System.Collections;
using System.Collections.Generic;


namespace Lecture9Iterator
{
	abstract class BinaryOperation: Expression
	{
		private Expression left;

		private Expression right;


		public BinaryOperation(Expression left, Expression right)
		{
			this.left = left;
			this.right = right;
		}


		public int GetValue()
		{
			return Compute(left.GetValue(), right.GetValue());
		}


		public IEnumerator<Expression> GetEnumerator()
		{
			foreach (Expression expr in left) {
				yield return expr;
			}

			foreach (Expression expr in right) {
				yield return expr;
			}
		}


		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}


		abstract protected int Compute(int left, int right);
	}
}
