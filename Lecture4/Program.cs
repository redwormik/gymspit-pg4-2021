using System;
using System.Collections.Generic;


namespace Lecture4
{
	class Program
	{
		static string ReadLine(string prompt)
		{
			Console.Write("{0}: ", prompt);
			return Console.ReadLine();
		}


		static string ReadWord()
		{
			return ReadLine("Enter a word to translate");
		}


		static string ReadQuery()
		{
			return ReadLine("Enter a word to find");
		}


		static void Main(string[] args)
		{
			IDictionary<string, string> dictionary = new Dictionary<string, string>();

			string word = ReadWord();
			while (word != "") {
				string translation = ReadLine(string.Format("Enter a translation of \"{0}\"", word));
				dictionary[word] = translation;
				word = ReadWord();
			}

			string query = ReadQuery();
			while (query != "") {
				if (dictionary.ContainsKey(query)) {
					Console.WriteLine("Translation of \"{0}\" is \"{1}\".", query, dictionary[query]);
				} else {
					Console.WriteLine("Translation of \"{0}\" not found.", query);
				}
				query = ReadQuery();
			}
		}
	}
}
