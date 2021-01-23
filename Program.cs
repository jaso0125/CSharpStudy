using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 任意の位置から指定文字数文を取得(Substring)
			var name = "じゅげむじゅげむごこうのすりきれ";
			Console.WriteLine($"----------------Substring------------------");
			Console.WriteLine($"{name.Substring(0, 4)}");
			Console.WriteLine($"{name.Substring(4, 4)}");
			Console.WriteLine($"{name.Substring(8)}");
			Console.WriteLine($"-------------------------------------------");

			// 任意の文字列の存在有無を取得(Contains)
			Console.WriteLine($"----------------Contains-------------------");
			var str = "あいさつは魔法の言葉";
			Console.WriteLine($"{str.Contains("あいさつ")}"); // true
			Console.WriteLine($"{str.Contains("魔法")}"); // true
			Console.WriteLine($"{str.Contains("こんにちは")}"); // false
			Console.WriteLine($"-------------------------------------------");

			// 文字列の位置を検索(IndexOf)
			Console.WriteLine($"----------------IndexOf--------------------");
			var str1 = "朝こそタンパク質を摂取しよう！";
			Console.WriteLine($"{str1.IndexOf("タンパク質")}"); // 4文字目で一致するので3を返す
			Console.WriteLine($"{str1.IndexOf("摂取", 9)}"); // 9文字目で一致するので9を返す(検索開始位置9)
			Console.WriteLine($"{str1.IndexOf("糖質")}"); // 一致しないので-1
			Console.WriteLine($"-------------------------------------------");

			// 文字列を置換(Replace)
			Console.WriteLine($"----------------Replace--------------------");
			var str2 = "となりの柿はよく客食う柿だ";
			Console.WriteLine($"{str2.Replace("柿", "客")}"); // となりの客はよく客食う客だ(客食い・・)
			Console.WriteLine($"-------------------------------------------");

			Console.Read();
		}
	}
}