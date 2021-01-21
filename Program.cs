using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 文字列の長さを取得する
			var str = "こんにちは！";
			var hello = "Hello World!";

			Console.WriteLine($"---------文字列の長さを取得する----------");
			Console.WriteLine($"strの長さは  ：{str.Length}"); // 結果：6
			Console.WriteLine($"helloの長さは：{hello.Length}"); // 結果：12
			Console.WriteLine($"-----------------------------------------\n");

			// アルファベットの大文字小文字変換
			Console.WriteLine($"---------文字列の長さを取得する----------");
			var str1 = "ABCDEFG";
			var str2 = "hijklmn";

			Console.WriteLine($"大文字⇒小文字変換：{str1}⇒{str1.ToLower()}"); // 小文字変換
			Console.WriteLine($"小文字⇒大文字変換：{str2}⇒{str2.ToUpper()}"); // 大文字変換
			Console.WriteLine($"-----------------------------------------\n");

			// 文字列のnull/空文字判定
			string str3 = "";
			string str4 = "おはよう";
			string str5 = null;

			Console.WriteLine($"---------文字列のnull/空文字判定---------");
			Console.WriteLine($"{string.IsNullOrEmpty(str3)}"); // 結果：空文字なので「true」
			Console.WriteLine($"{string.IsNullOrEmpty(str4)}"); // 結果：文字列が入っているので「false」
			Console.WriteLine($"{string.IsNullOrEmpty(str5)}"); // 結果：null値なので「true」
			Console.WriteLine($"-----------------------------------------\n");

			// 文字列の大小比較
			var str6 = "A";
			var str7 = "B";
			Console.WriteLine($"-------------文字列の大小比較------------");
			Console.WriteLine($"同じ文字列同士の比較：{str6.CompareTo(str6)}"); // 結果：0
			Console.WriteLine($"比較先が小さい　　　：{str6.CompareTo(str7)}"); // 結果：-1
			Console.WriteLine($"比較先が大きい　　　：{str7.CompareTo(str6)}"); // 結果：1
			Console.WriteLine($"-----------------------------------------\n");

			Console.Read();
		}
	}
}