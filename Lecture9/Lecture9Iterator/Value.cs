﻿using System;
using System.Collections;
using System.Collections.Generic;


namespace Lecture9Iterator
{
	class Value: Expression
	{
		int value;


		public Value(int value)
		{
			this.value = value;
		}


		public int GetValue()
		{
			return value;
		}


		public IEnumerator<Expression> GetEnumerator()
		{
			yield return this;
		}


		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
