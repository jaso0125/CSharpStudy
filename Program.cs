using System;
using System.Collections.Generic;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// キュー(Queue)
			var queue = new Queue<int>();

			// 要素の追加(Enqueue)
			queue.Enqueue(10);
			queue.Enqueue(20);
			queue.Enqueue(30);
			queue.Enqueue(40);
			queue.Enqueue(50);

			// queueの中身を出力
			Console.WriteLine("-----------------queueの中身を出力---------------------");
			foreach (var item in queue)
			{
				Console.WriteLine(item);
				// 結果：10，20，30，40，50
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 格納されている要素数を取得(Count)
			Console.WriteLine("----------格納されている要素数を取得(Count)------------");
			Console.WriteLine($"要素数は{queue.Count}個です。"); // 結果：5
			Console.WriteLine("-------------------------------------------------------\n");

			// キューの先頭から要素を取得(Peek)
			Console.WriteLine("-----------キューの先頭から要素を取得(Peek)-----------");
			Console.WriteLine(queue.Peek()); // 結果：10
			Console.WriteLine("-------------------------------------------------------\n");

			// キューの先頭から要素を取得し、削除(Dequeue)
			Console.WriteLine("------キューの先頭から要素を取得し、削除(Dequeue)------");

			Console.WriteLine(queue.Dequeue()); // 結果：10
			Console.WriteLine("-------------------------------------------------------\n");

			Console.WriteLine("----------------削除後のキュー(Dequeue)----------------");
			foreach (var item in queue)
			{
				Console.WriteLine(item);
				// 結果：20，30，40, 50
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 要素の有無判定(Contains)
			Console.WriteLine("---------------要素の有無判定(Contains)----------------");
			if (queue.Contains(30)) // 「30」がqueueに含まれているかを判定
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
			queue.Clear();
			Console.WriteLine($"要素数は{queue.Count}個です。");
			Console.WriteLine("-------------------------------------------------------\n");

			Console.Read();
		}
	}
}