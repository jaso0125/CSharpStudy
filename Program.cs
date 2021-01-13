using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 論理演算子
			bool a = false;
			bool b = false;

			Console.WriteLine($"----------aとbがともにfalseの場合----------");
			Console.WriteLine($"a && b：{a && b}"); // 結果：false
			Console.WriteLine($"a || b：{a || b}"); // 結果：false
			Console.WriteLine($"a ^ b ：{a ^ b}"); // 結果：false
			Console.WriteLine($"!a    ：{!a}"); // 結果：true
			Console.WriteLine($"!b    ：{!b}"); // 結果：true
			Console.WriteLine($"-------------------------------------------");

			a = false;
			b = true;

			Console.WriteLine($"----------aがfalse、bがtrueの場合----------");
			Console.WriteLine($"a && b：{a && b}"); // 結果：false
			Console.WriteLine($"a || b：{a || b}"); // 結果：true
			Console.WriteLine($"a ^ b ：{a ^ b}"); // 結果：true
			Console.WriteLine($"!a    ：{!a}"); // 結果：true
			Console.WriteLine($"!b    ：{!b}"); // 結果：false
			Console.WriteLine($"-------------------------------------------");

			a = true;
			b = false;

			Console.WriteLine($"----------aがtrue、bがfalseの場合----------");
			Console.WriteLine($"a && b：{a && b}"); // 結果：false
			Console.WriteLine($"a || b：{a || b}"); // 結果：true
			Console.WriteLine($"a ^ b ：{a ^ b}"); // 結果：true
			Console.WriteLine($"!a    ：{!a}"); // 結果：false
			Console.WriteLine($"!b    ：{!b}"); // 結果：true
			Console.WriteLine($"-------------------------------------------");

			a = true;
			b = true;

			Console.WriteLine($"----------aとbがともにtrueの場合-----------");
			Console.WriteLine($"a && b：{a && b}"); // 結果：true
			Console.WriteLine($"a || b：{a || b}"); // 結果：true
			Console.WriteLine($"a ^ b ：{a ^ b}"); // 結果：false
			Console.WriteLine($"!a    ：{!a}"); // 結果：false
			Console.WriteLine($"!b    ：{!b}"); // 結果：false
			Console.WriteLine($"-------------------------------------------");
			Console.Read();
		}
	}
}