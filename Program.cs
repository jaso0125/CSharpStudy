using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 日時の差を取得(Substract)
			var date1 = new DateTime(2021, 1, 1, 8, 0, 0); // 2021/1/1 08:00:00
			var date2 = DateTime.Now;

			Console.WriteLine("----------------Substract----------------");
			Console.WriteLine($"{date1.Subtract(date2)}"); // date1 - date2の差分を出力

			Console.WriteLine("-----------------------------------------");

			// 任意の期間を作成(TimeSpan)
			var time1 = new TimeSpan(5, 10, 45, 30, 1500);
			var time2 = new TimeSpan(1, 20, 10, 7);
			var time3 = new TimeSpan(6, 53, 9);
			Console.WriteLine("-----------------TimeSpan----------------");
			Console.WriteLine($"{time1}"); // 5日10時間45分30秒1500ミリ秒
			Console.WriteLine($"{time2}"); // 1日20時間10分7秒
			Console.WriteLine($"{time3}"); // 6時間53分9秒
			Console.WriteLine("-----------------------------------------");

			Console.Read();
		}
	}
}