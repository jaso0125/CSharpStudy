using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// for文
			Console.WriteLine("--------------for文---------------");
			for (var i = 0; i < 10; i++)
			{
				Console.WriteLine(i); // 0,1,2,3,4,5,6,7,8,9を出力
			}
			Console.WriteLine("----------------------------------");

			// 注意：下記実行する際、3例のうちの2例はコメントアウト「//」をしてください。
			// 例１を実行する場合、例２と例３をコメントアウトする
			// for文無限ループの例１(Ctrl+Cで解除できるよ)
			Console.WriteLine("------for文無限ループの例１-------");
			for (var i = 0; ; i++)
			{
				Console.WriteLine(i); // 条件式がないため無限ループが発生する
			}
			Console.WriteLine("----------------------------------");

			// for文無限ループの例２(Ctrl+Cで解除できるよ)
			//Console.WriteLine("------for文無限ループの例２-------");
			//for (; ; )
			//{
			//	Console.WriteLine("無限ループ"); // 初期化式、条件式、反復子全て省略すると無限ループが発生する
			//}
			//Console.WriteLine("----------------------------------");

			// for文無限ループの例３(Ctrl+Cで解除できるよ)
			//Console.WriteLine("------for文無限ループの例３-------");
			//for (var i = 0; i < 10; i--)
			//{
			//	Console.WriteLine(i); // 「i--」で「i<10」がfalseになることがないので無限ループが発生する
			//}
			//Console.WriteLine("----------------------------------");

			// 下記はコメントアウトしなくてもよい
			Console.Read();
		}
	}
}