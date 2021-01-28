using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 任意の日付を作成(DateTime)
			Console.WriteLine("---------------DateTime---------------");
			var date = new DateTime(2021, 1, 29);
			var date1 = new DateTime(2021, 1, 29, 8, 30, 50);

			Console.WriteLine(date); // 結果：2021/01/29 0:00:00
			Console.WriteLine(date1); // 結果：2021/01/29 8:30:50
			Console.WriteLine("--------------------------------------");

			// 日付から曜日を取得(DayOfWeek)
			Console.WriteLine("--------------DayOfWeek---------------");
			var str0 = new DateTime(2021, 1, 24); // 2021年1月24日(日)
			var str1 = new DateTime(2021, 1, 25); // 2021年1月25日(月)
			var str2 = new DateTime(2021, 1, 26); // 2021年1月26日(火)
			var str3 = new DateTime(2021, 1, 27); // 2021年1月27日(水)
			var str4 = new DateTime(2021, 1, 28); // 2021年1月28日(木)
			var str5 = new DateTime(2021, 1, 29); // 2021年1月29日(金)
			var str6 = new DateTime(2021, 1, 30); // 2021年1月30日(土)

			Console.WriteLine(str0.DayOfWeek); // 結果：Sunday(日曜日)
			Console.WriteLine(str1.DayOfWeek); // 結果：Monday(月曜日)
			Console.WriteLine(str2.DayOfWeek); // 結果：Tuesday(火曜日)
			Console.WriteLine(str3.DayOfWeek); // 結果：Wednesday(水曜日)
			Console.WriteLine(str4.DayOfWeek); // 結果：Thursday(木曜日)
			Console.WriteLine(str5.DayOfWeek); // 結果：Friday(金曜日)
			Console.WriteLine(str6.DayOfWeek); // 結果：Saturday(土曜日)
			Console.WriteLine("--------------------------------------");

			// 任意の日数/時刻を加算した日付を取得(AddDays/AddHours)
			Console.WriteLine("-----------AddDays/AddHours-----------");
			var date2 = DateTime.Now;

			Console.WriteLine(date2.AddDays(3));
			Console.WriteLine(date2.AddHours(-3));

			Console.WriteLine("--------------------------------------");

			Console.Read();
		}
	}
}