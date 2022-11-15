using System;
using System.Collections.Generic;


namespace Lecture9Iterator
{
	interface Expression: IEnumerable<Expression>
	{
		int GetValue();
	}
}
