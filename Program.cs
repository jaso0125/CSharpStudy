using System;

namespace CSharp
{
	internal class Program
	{
		// 列挙型の宣言
		private enum DayOfWeek
		{
			Sunday,     // 0
			Monday,     // 1
			Tuesday,    // 2
			Wednesday,  // 3
			Thursday,   // 4
			Friday,     // 5
			Saturday    // 6
		}

		private static void Main(string[] args)
		{
			// 定数の宣言
			const string NAME = "C#Tips #";
			const int TIPS_NUM = 24;

			Console.WriteLine("--------------------定数の宣言--------------------");
			Console.WriteLine(NAME + TIPS_NUM); // 結果：C#Tips #24
			Console.WriteLine("--------------------------------------------------");

			Console.WriteLine("------------------列挙型の宣言--------------------");

			// 値が0または6の場合、「休日」と出力し、1～5の場合、「平日」と出力する
			var sat = DayOfWeek.Saturday; // 6

			if (sat == DayOfWeek.Sunday || sat == DayOfWeek.Saturday)
			{
				Console.WriteLine("休日");
			}
			else if (sat == DayOfWeek.Monday || sat == DayOfWeek.Tuesday || sat == DayOfWeek.Wednesday || sat == DayOfWeek.Thursday || sat == DayOfWeek.Friday)
			{
				Console.WriteLine("平日");
			}

			Console.WriteLine("--------------------------------------------------");

			Console.Read();
		}
	}
}