using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// break文の例(for文)
			Console.WriteLine("------------break文の例(for文)--------------");

			var sum = 0;
			for (var i = 1; i <= 100; i++)
			{
				sum += i;
				Console.WriteLine($"ループ{i}回目合計：{sum}");
				if (sum > 100)
				{
					Console.WriteLine($"合計：{sum}");
					break; // sumの値が100を超えたらループを抜ける
				}
			}
			Console.WriteLine("--------------------------------------------");

			// break文の例(while文)
			Console.WriteLine("-----------break文の例(while文)-------------");

			var num = 0;
			while (true)
			{
				if (num >= 10)
				{
					break; // numの値が10以上の場合、ループを抜ける
				}
				Console.WriteLine(num);
				num++;
			}
			Console.WriteLine("--------------------------------------------");

			// continue文の例
			Console.WriteLine("--------------continue文の例----------------");
			var val = 0;
			for (var i = 1; i <= 100; i++)
			{
				if (i % 2 != 0) // iの値を2で割って余りが0にならない値(奇数)
				{
					continue; // 奇数の場合はcontinue文でループをスキップ
				}
				val += i;
			}
			Console.WriteLine($"valの合計：{val}");
			Console.WriteLine("--------------------------------------------");

			Console.Read();
		}
	}
}