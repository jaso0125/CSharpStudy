using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 日付文字列を日付に変換(Parse / TryParse)
			Console.WriteLine("--------Parse / TryParse---------");

			var date = "2021-01-31";
			DateTime dt;
			Console.WriteLine($"{DateTime.Parse(date)}"); // 日付型に変換
			Console.WriteLine($"{DateTime.TryParse(date, out dt)}"); // True
			Console.WriteLine("---------------------------------");

			// 日付データを文字列に変換(ToString/To・・シリーズ)
			Console.WriteLine("-------------ToString------------");
			var date1 = DateTime.Now;

			Console.WriteLine($"{date1.ToString()}");
			Console.WriteLine($"{date1.ToShortDateString()}");
			Console.WriteLine($"{date1.ToString("yyyy年MM月dd日")}");
			Console.WriteLine("---------------------------------");

			Console.Read();
		}
	}
}