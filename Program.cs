using System;
using System.Collections.Generic;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// スタック(Stack)
			var stack = new Stack<int>();

			// 要素の追加(Push)
			stack.Push(10);
			stack.Push(20);
			stack.Push(30);
			stack.Push(40);
			stack.Push(50);

			// stackの中身を出力
			Console.WriteLine("-----------------stackの中身を出力---------------------");
			foreach (var item in stack)
			{
				Console.WriteLine(item);
				// 結果：50，40，30，20，10
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 格納されている要素数を取得(Count)
			Console.WriteLine("----------格納されている要素数を取得(Count)------------");
			Console.WriteLine($"要素数は{stack.Count}個です。"); // 結果：5
			Console.WriteLine("-------------------------------------------------------\n");

			// スタックの末尾から要素を取得(Peek)
			Console.WriteLine("----------スタックの末尾から要素を取得(Peek)-----------");
			Console.WriteLine(stack.Peek()); // 結果：50
			Console.WriteLine("-------------------------------------------------------\n");

			// スタックの末尾から要素を取得し、削除(Pop)
			Console.WriteLine("-------スタックの末尾から要素を取得し、削除(Pop)-------");

			Console.WriteLine(stack.Pop()); // 結果：50
			Console.WriteLine("-------------------------------------------------------\n");

			Console.WriteLine("----------------削除後のスタック(Pop)------------------");
			foreach (var item in stack)
			{
				Console.WriteLine(item);
				// 結果：40，30，20，10
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 要素の有無判定(Contains)
			Console.WriteLine("---------------要素の有無判定(Contains)----------------");
			if (stack.Contains(30)) // 「30」がstackに含まれているかを判定
			{
				Console.WriteLine($"要素が存在します。");
			}
			else
			{
				Console.WriteLine($"要素が存在しません。");
			}

			Console.WriteLine("-------------------------------------------------------\n");

			// リストをクリア(Clear)
			Console.WriteLine("-----------------リストをクリア(Clear)-----------------");
			stack.Clear();
			Console.WriteLine($"要素数は{stack.Count}個です。");
			Console.WriteLine("-------------------------------------------------------\n");

			Console.Read();
		}
	}
}