using System;
using System.Collections.Generic;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var list = new List<string>();

			list.Add("い");
			list.Add("ろ");
			list.Add("は");
			list.Add("に");

			foreach (var item in list)
			{
				Console.WriteLine(item);
			}
			Console.Read();
		}
	}
}