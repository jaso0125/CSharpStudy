using System;
using System.Collections.Generic;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// 双方向連結リスト(LinkedList)
			int[] nums = { 10, 20, 30, 40, 50 };
			var list = new LinkedList<int>(nums);

			// listの中身を出力
			Console.WriteLine("-----------------listの中身を出力----------------------");
			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：10，20，30，40，50
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 格納されている要素数を取得(Count)
			Console.WriteLine("----------格納されている要素数を取得(Count)------------");
			Console.WriteLine(list.Count); // 結果：5
			Console.WriteLine("-------------------------------------------------------\n");

			// 先頭の要素を取得(First)
			Console.WriteLine("---------------先頭の要素を取得(First)-----------------");
			Console.WriteLine(list.First.Value); // 結果：10
			Console.WriteLine("-------------------------------------------------------\n");

			// 末尾の要素を取得(Last)
			Console.WriteLine("---------------末尾の要素を取得(Last)------------------");
			Console.WriteLine(list.Last.Value); // 結果：50
			Console.WriteLine("-------------------------------------------------------\n");

			// 先頭に要素を追加(AddFirst)
			Console.WriteLine("-------------先頭に要素を追加(AddFirst)----------------");
			list.AddFirst(5); // 先頭に「5」を追加
			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：5, 10，20，30，40，50
			}

			// 末尾に要素を追加(AddLast)
			Console.WriteLine("-------------末尾に要素を追加(AddLast)----------------");
			list.AddLast(60); // 末尾に「60」を追加
			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：5, 10，20，30，40，50, 60
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 指定したノードの後に要素を追加(AddAfter)
			Console.WriteLine("-------指定したノードの後に要素を追加(AddAfter)--------");

			list.AddAfter(list.First, 7); // 先頭のノードの次に「7」を追加
			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：5, 7, 10，20，30，40，50, 60
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 指定したノードの前に要素を追加(AddBefore)
			Console.WriteLine("------指定したノードの後に要素を追加(AddBefore)--------");

			list.AddBefore(list.Last, 55); // 末尾のノードの前に「55」を追加
			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：5, 7, 10，20，30，40，50, 55, 60
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 要素を削除(Remove)
			Console.WriteLine("-------------------要素を削除(Remove)------------------");
			list.Remove(7); // 「7」を削除

			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：5, 10，20，30，40，50, 55, 60
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 先頭の要素を削除(RemoveFirst)
			Console.WriteLine("-------------先頭の要素を削除(RemoveFirst)-------------");
			list.RemoveFirst(); // 先頭の要素「5」を削除

			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：10，20，30，40，50, 55, 60
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 末尾の要素を削除(RemoveLast)
			Console.WriteLine("-------------末尾の要素を削除(RemoveLast)-------------");
			list.RemoveLast(); // 先頭の要素「60」を削除

			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：10，20，30，40，50, 55
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 要素の有無判定(Contains)
			Console.WriteLine("---------------要素の有無判定(Contains)----------------");
			if (list.Contains(30)) // 「30」がlistに含まれているかを判定
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
			list.Clear();
			Console.WriteLine($"要素数は{list.Count}個です。");
			Console.WriteLine("-------------------------------------------------------\n");

			Console.Read();
		}
	}
}