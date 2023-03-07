// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives

using System;
using System.IO;

namespace Lecture22
{
	class Program
	{
		static string GetPath(params string[] segments)
		{
			string path = Directory.GetCurrentDirectory();
#if DEBUG
			path = Path.Combine(path, "..", "..");
#endif
			for (int i = 0; i < segments.Length; i += 1) {
				path = Path.Combine(path, segments[i]);
			}
			return path;
		}


		static void Main(string[] args)
		{
#if MYSYMBOL
			Console.WriteLine("MYSYMBOL defined");
#endif
			Random rnd = new Random();
			string path = GetPath("data", "words.txt");
			Console.WriteLine(path);
			string[] words = File.ReadAllLines(path);
			int length = 4;
			
			for (int i = 0; i < length; i += 1) {
				int index = rnd.Next(i, words.Length);
				(words[i], words[index]) = (words[index], words[i]);
				Console.WriteLine(words[i]);
			}

			Console.ReadKey();
		}
	}
}
