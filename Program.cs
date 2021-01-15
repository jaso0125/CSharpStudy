using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// if文の例
			var day = "金曜日";
			Console.WriteLine("-----------if文の例-------------");

			if (day == "月曜日")
			{
				Console.WriteLine("月曜日・・・、また仕事かー！");
			}
			else if (day == "火曜日")
			{
				Console.WriteLine("まだ火曜日（；ω；｀）");
			}
			else if (day == "水曜日")
			{
				Console.WriteLine("やっと半分！");
			}
			else if (day == "木曜日")
			{
				Console.WriteLine("もうちょっと！！");
			}
			else if (day == "金曜日")
			{
				Console.WriteLine("明日は土曜日！ヾ(o´∀｀o)ﾉﾜｧｰｨ♪");
			}
			Console.WriteLine("--------------------------------");

			// switch文の例
			Console.WriteLine("----------switch文の例-----------");
			switch (day)
			{
				case "月曜日":
					Console.WriteLine("月曜日・・・、また仕事かー！");
					break;

				case "火曜日":
					Console.WriteLine("まだ火曜日（；ω；｀）");
					break;

				case "水曜日":
					Console.WriteLine("やっと半分！");
					break;

				case "木曜日":
					Console.WriteLine("もうちょっと！！");
					break;

				case "金曜日":
					Console.WriteLine("明日は土曜日！ヾ(o´∀｀o)ﾉﾜｧｰｨ♪");
					break;

				default:
					Console.WriteLine("休日なう");
					break;
			}
			Console.WriteLine("--------------------------------");

			// フォールスルーの例
			var name = "煉獄杏寿郎";
			Console.WriteLine("-------フォールスルーの例-------");
			switch (name)
			{
				case "竈門炭治郎":
				case "我妻善逸":
				case "嘴平伊之助":
					Console.WriteLine("かまぼこ隊だ！");
					break;

				case "煉獄杏寿郎":
				case "冨岡義勇":
					Console.WriteLine("柱様だー！！");
					break;
			}
			Console.WriteLine("--------------------------------");

			Console.Read();
		}
	}
}