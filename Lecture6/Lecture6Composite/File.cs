using System;
using System.IO;


namespace Lecture6Composite
{
	interface File
	{
		string GetName();

		void PrintOn(TextWriter writer, int indent = 0);
	}
}
