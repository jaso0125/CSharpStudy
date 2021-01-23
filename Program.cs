using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 文字列内の一部文字列を削除(Remove)
			Console.WriteLine("-----------------Remove----------------");

			var str = "あかさたなはまやらわ";
			Console.WriteLine($"{str.Remove(3)}"); // 結果：あかさ
			Console.WriteLine($"{str.Remove(5, 4)}"); // 結果：あかさたなわ
			Console.WriteLine("---------------------------------------");

			// 文字列の両端から空白を削除(Trim/TrimStart/TrimEnd)
			Console.WriteLine("-----------------Remove----------------");
			var str1 = "　 abc def ghi  ";
			Console.WriteLine($"「{str1.Trim()}」"); // 両端の空白を削除
			Console.WriteLine($"「{str1.TrimStart()}」"); // 先頭の空白を削除
			Console.WriteLine($"「{str1.TrimEnd()}」"); // 末尾の空白を削除

			Console.WriteLine("---------------------------------------");

			// 文字列の始まりと終わりを判定(StartsWith/EndsWith)
			Console.WriteLine("----------StartsWith/EndsWith----------");

			var str2 = "吾輩は猫である";

			// StartsWith
			if (str2.StartsWith("吾輩"))
			{
				Console.WriteLine("吾輩で始まっている。");
			}
			else
			{
				Console.WriteLine("吾輩ではない！");
			}

			// EndsWith
			if (str2.EndsWith("猫である"))
			{
				Console.WriteLine("猫である！");
			}
			else
			{
				Console.WriteLine("猫ではない！");
			}

			Console.WriteLine("---------------------------------------");

			// 文字列内に別の文字列を追加(Insert)
			Console.WriteLine("-----------------Insert----------------");
			var str3 = "こぶたたぬききつね";

			Console.WriteLine($"{str3.Insert(9, "ねこ") }");
			// 結果：こぶたたぬききつねねこ
			Console.WriteLine("---------------------------------------");
			Console.Read();
		}
	}
}