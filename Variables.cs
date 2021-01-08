using System;

namespace CSharp
{
	public class Variables
	{
		// 変数の宣言
		public Variables()
		{
			// 変数の宣言
			int num = 1; // 整数
			double pie = 3.14; // 浮動小数点
			string str = "こんにちは"; //文字列

			Console.WriteLine($"num = {num}");
			Console.WriteLine($"pie = {pie}");
			Console.WriteLine($"str = {str}");
			Console.WriteLine(Environment.NewLine);

			// 定数の定義
			// 消費税率
			const double Tax = 1.10;

			// ある商品１の価格
			int price1 = 500;
			// 合計
			double total1 = price1 * Tax; // 500 × 1.10 = 550

			// ある商品２の価格
			int price2 = 1000;
			// 合計
			double total2 = price2 * Tax; // 1000 × 1.10 = 1100

			Console.WriteLine($"total1 = {total1}");
			Console.WriteLine($"total2 = {total2}");
			Console.ReadKey();
		}
	}
}