using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 数値でない場合の演算
			Console.WriteLine(1 + 2); // 数値同士の加算なので結果：3
			Console.WriteLine("富士山の標高は" + 3776 + "メートル"); // 文字列と数値が混在 結果：富士山の標高は3776メートル
			Console.WriteLine("こんにちは！" + "じゃそさん"); // 文字列同士なので結合 結果：こんにちは！じゃそさん

			Console.WriteLine($"-----------------------------------------------------");
			Console.WriteLine($"-----------------------前置演算----------------------");
			//前置演算
			var i = 1;
			var num = ++i;
			Console.WriteLine(i);   // 結果：2
			Console.WriteLine(num); // 結果：2
			Console.WriteLine($"-----------------------------------------------------");
			Console.WriteLine($"-----------------------後置演算----------------------");
			//後置演算
			var j = 1;
			var num2 = j++;
			Console.WriteLine(j);   // 結果：2
			Console.WriteLine(num2); // 結果：1
			Console.WriteLine($"-----------------------------------------------------");

			//除算の挙動
			Console.WriteLine($"----------------------除算の挙動---------------------");
			Console.WriteLine(3 / 4); // 結果；0
			double result = 3 / 4;
			Console.WriteLine(result); // 結果：0 result変数がdoubleでも被演算子が整数なら整数で返ってしまう
			double a = 3;
			int b = 4;
			Console.WriteLine(a / b); // 結果；0.75 被演算子のどちらかがdouble型なら結果もdoubleで返る
			Console.WriteLine($"-----------------------------------------------------");

			Console.Read();
		}
	}
}