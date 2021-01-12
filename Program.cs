using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 値型の比較
			int a = 100;
			int b = 100;

			Console.WriteLine($"--------------値型の比較--------------");
			Console.WriteLine(a == b); // 結果：true
			Console.WriteLine(a.Equals(b)); // 結果：true
			Console.WriteLine($"--------------------------------------");

			// 参照型の比較(string以外)
			object obj1 = new { name = "じゃそ" }; // とは異なるメモリを参照している
			object obj2 = new { name = "じゃそ" }; //
			object obj3 = obj1;

			Console.WriteLine($"-------------参照型の比較-------------");
			Console.WriteLine(obj1 == obj2); // obj1とobj2は異なるアドレスを参照しているので結果：false
			Console.WriteLine(obj1.Equals(obj2)); // obj1とobj2の中身は同じなので結果：true
			Console.WriteLine(obj1 == obj3); // obj1とobj3は同じアドレスを参照しているので結果：true
			Console.WriteLine($"--------------------------------------");

			// stringの比較
			string str1 = "こんにちは！";
			string str2 = "こんにちは！";
			Console.WriteLine($"-------------stringの比較-------------");
			Console.WriteLine(str1 == str2); // 結果：true
			Console.WriteLine(str1.Equals(str2)); // 結果：true
			Console.WriteLine($"--------------------------------------");

			// 条件演算子
			bool isHuman = true;
			Console.WriteLine($"-------------条件演算子-------------");
			Console.WriteLine(isHuman ? "彼は人間です" : "彼は鬼です");
			Console.WriteLine($"------------------------------------");

			// null合体演算子
			string str = "今夜が山田";
			string nStr = null;
			Console.WriteLine($"-----------null合体演算子-----------");
			Console.WriteLine(str ?? "田中です");
			Console.WriteLine(nStr ?? "nullでしたので文字列置いておきますね");
			Console.WriteLine($"------------------------------------");
			Console.Read();
		}
	}
}