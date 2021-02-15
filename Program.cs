using System;
using System.Collections.Generic;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// ディクショナリ(Dictionary)
			var dic = new Dictionary<string, string>();

			// 要素の追加(Add)
			dic.Add("Red", "赤");
			dic.Add("Blue", "青");
			dic.Add("Yellow", "黄");
			dic.Add("Black", "黒");
			dic.Add("White", "白");

			// 格納されている要素数を取得(Count)
			Console.WriteLine("-----格納されている要素数を取得(Count)------");
			Console.WriteLine($"要素数は{dic.Count}個です。"); // 結果：5
			Console.WriteLine("--------------------------------------------\n");

			// キーの一覧を取得(Keys)
			Console.WriteLine("-----------キーの一覧を取得(Keys)-----------");
			foreach (var item in dic.Keys)
			{
				Console.WriteLine($"{item}");
				// 結果：Red,Blue,Yellow,Black,White
			}
			Console.WriteLine("--------------------------------------------\n");

			// 値の一覧を取得(Values)
			Console.WriteLine("-----------値の一覧を取得(Values)-----------");
			foreach (var item in dic.Values)
			{
				Console.WriteLine($"{item}");
				// 結果：赤,青,黄,黒,白
			}
			Console.WriteLine("--------------------------------------------\n");

			// 指定したキーの値を出力(TryGetValue)
			Console.WriteLine("-----指定したキーの値を出力(TryGetValue)----");

			dic.TryGetValue("Yellow", out string value);
			Console.WriteLine(value);
			// 結果：黄
			Console.WriteLine("--------------------------------------------\n");

			// 指定したキーが含まれるか(ContainsKey)
			Console.WriteLine("---指定したキーが含まれるか(ContainsKey)----");

			Console.WriteLine(dic.ContainsKey("Pink")); // 結果：false

			Console.WriteLine("--------------------------------------------\n");

			// 指定した値が含まれるか(ContainsValue)
			Console.WriteLine("---指定した値が含まれるか(ContainsValue)----");
			Console.WriteLine(dic.ContainsValue("白")); // 結果：true
			Console.WriteLine("--------------------------------------------\n");

			// すべての要素を削除(Clear)
			Console.WriteLine("---------すべての要素を削除(Clear)----------");
			dic.Clear();
			Console.WriteLine($"要素数は{dic.Count}個です。");
			Console.WriteLine("--------------------------------------------\n");

			Console.Read();
		}
	}
}