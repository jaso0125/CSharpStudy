using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//foreach文
			var fruits = new string[] { "バナナ", "オレンジ", "りんご", "メロン" };

			Console.WriteLine("------------foreach文--------------");

			foreach (var fruit in fruits)
			{
				Console.WriteLine(fruit); // 順に「バナナ」「オレンジ」「りんご」「メロン」を出力
			}
			// 4回ループしたらforeach文を抜ける
			Console.WriteLine("ループ終わり");
			Console.WriteLine("-----------------------------------");

			Console.Read();
		}
	}
}