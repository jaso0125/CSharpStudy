using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 指定した文字数まで先頭に空白を追加(PadLeft)
			var str = "1234";

			Console.WriteLine("------------------PadLeft-------------------");
			Console.WriteLine($"「{str.PadLeft(10)}」"); // 10文字になるまで先頭に空白を埋める
			Console.WriteLine($"「{str.PadLeft(10, '0')}」"); // 10文字になるまで先頭に「0」を埋める

			Console.WriteLine("--------------------------------------------");

			// 指定した文字数まで末尾に空白を追加(PadRight)
			var str1 = "9876";

			Console.WriteLine("------------------PadRight------------------");
			Console.WriteLine($"「{str1.PadRight(10)}」"); // 10文字になるまで末尾に空白を埋める
			Console.WriteLine($"「{str1.PadRight(10, '0')}」"); // 10文字になるまで末尾に「0」を埋める

			Console.WriteLine("--------------------------------------------");

			Console.WriteLine("------------------Split---------------------");

			// 文字列を分割(Split)
			var str2 = "りんご,ゴリラ,ラッパ,パンツ";

			var array = str2.Split(',');

			foreach (var item in array)
			{
				Console.WriteLine($"{item}");
			}
			Console.WriteLine("--------------------------------------------");

			// 文字列配列を連結(Join)
			Console.WriteLine("------------------Join----------------------");
			var array2 = new[] { "りんご", "ゴリラ", "ラッパ", "パンツ" };

			Console.WriteLine($"{string.Join(",", array2)}");

			Console.WriteLine("--------------------------------------------");
			Console.Read();
		}
	}
}