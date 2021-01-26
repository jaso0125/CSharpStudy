using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 現在の日付と時刻を取得(Today/Now)
			Console.WriteLine("--------------Today/Now-----------------");

			Console.WriteLine(DateTime.Today);
			Console.WriteLine(DateTime.Now);

			Console.WriteLine("----------------------------------------");
			// 日付の年/月/日を取得(Year/Month/Day)
			Console.WriteLine("------------Year/Month/Day--------------");

			var date = DateTime.Now;
			Console.WriteLine(date.Year); // 年を取得
			Console.WriteLine(date.Month); // 月を取得
			Console.WriteLine(date.Day); // 日を取得

			Console.WriteLine("----------------------------------------");

			// 時刻の時/分/秒を取得(Hour/Minute/Second)
			Console.WriteLine("----------Hour/Minute/Second------------");

			var date1 = DateTime.Now;
			Console.WriteLine(date1.Hour); // 時間を取得
			Console.WriteLine(date1.Minute); // 分を取得
			Console.WriteLine(date1.Second); // 秒を取得

			Console.WriteLine("----------------------------------------");
			Console.Read();
		}
	}
}