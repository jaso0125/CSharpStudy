using System;
using System.Collections.Generic;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// リスト(List<T>)
			var list = new List<int> { 10, 20, 30, 40, 50 };

			// listの中身を出力
			Console.WriteLine("-----------------listの中身を出力----------------------");
			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：10，20，30，40，50
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 指定した要素を出力(GetRange)
			Console.WriteLine("-------------指定した要素を出力(GetRange)--------------");

			var rangeList = list.GetRange(1, 3); // インデックス番号1から3個の要素を取得

			foreach (var item in rangeList)
			{
				Console.WriteLine(item); //結果：20，30、40
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 格納されている要素数を取得(Count)
			Console.WriteLine("----------格納されている要素数を取得(Count)------------");
			Console.WriteLine(list.Count); // 結果：5
			Console.WriteLine("-------------------------------------------------------\n");

			// 要素を追加(Add)
			Console.WriteLine("--------------------要素を追加(Add)--------------------");

			list.Add(60); // 末尾に「60」を追加

			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：10，20，30，40，50, 60
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// コレクションを追加(AddRange)
			Console.WriteLine("--------------コレクションを追加(AddRange)-------------");
			int[] input = { 1, 2, 3, 4, 5 };

			list.AddRange(input); // 末尾にinputを追加

			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：10，20，30，40，50, 60, 1，2，3，4，5
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 要素をリスト内に挿入(Insert)
			Console.WriteLine("--------------要素をリスト内に挿入(Insert)-------------");

			list.Insert(2, 25); // インデックス番号2に「25」を挿入

			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：10，20，25, 30，40，50, 60, 1，2，3，4，5
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 要素を削除(Remove)
			Console.WriteLine("-------------------要素を削除(Remove)------------------");
			list.Remove(25); // 「25」を削除

			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：10，20，30，40，50, 60, 1，2，3，4，5
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 指定した要素を削除(RemoveRange)
			Console.WriteLine("------------指定した要素を削除(RemoveRange)------------");
			list.RemoveRange(6, 5); // インデックス番号6から要素を5個削除

			foreach (var item in list)
			{
				Console.WriteLine(item);
				// 結果：10，20，30，40，50, 60
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// リストをクリア(Clear)
			Console.WriteLine("-----------------リストをクリア(Clear)-----------------");
			list.Clear();
			Console.WriteLine($"要素数は{list.Count}個です。");

			Console.WriteLine("-------------------------------------------------------\n");

			// 要素の有無判定(Contains)
			Console.WriteLine("---------------要素の有無判定(Contains)----------------");

			var list2 = new List<int> { 1, 2, 3, 4, 5 };

			if (list2.Contains(6)) // 「6」がlist2に含まれているかを判定
			{
				Console.WriteLine($"要素が存在します。");
			}
			else
			{
				Console.WriteLine($"要素が存在しません。");
			}
			Console.WriteLine("-------------------------------------------------------\n");

			// 要素を先頭から検索(IndexOf)
			Console.WriteLine("--------------要素を先頭から検索(IndexOf)--------------");

			Console.WriteLine($"{list2.IndexOf(4)}"); // 結果：3

			Console.WriteLine("-------------------------------------------------------\n");

			// 要素を末尾から検索(LastIndexOf)
			Console.WriteLine("------------要素を末尾から検索(LastIndexOf)------------");

			Console.WriteLine($"{list2.LastIndexOf(2)}"); // 結果：1

			Console.WriteLine("-------------------------------------------------------\n");

			// 要素を配列にコピー(ToArray)
			Console.WriteLine("--------------要素を配列にコピー(ToArray)--------------");

			var array = list2.ToArray();

			Console.WriteLine($"list2の型：{list2.GetType()}");
			Console.WriteLine($"arrayの型：{array.GetType()}");

			Console.WriteLine("-------------------------------------------------------\n");

			// 要素の順番を反転(Reverse)
			Console.WriteLine("---------------要素の順番を反転(Reverse)---------------");

			Console.WriteLine("反転前の要素");
			foreach (var item in list2)
			{
				Console.WriteLine(item);
				// 結果：1，2，3，4，5
			}

			list2.Reverse(); // list2を反転

			Console.WriteLine("\n反転後の要素");
			foreach (var item in list2)
			{
				Console.WriteLine(item);
				// 結果：5，4，3，2，1
			}

			Console.WriteLine("-------------------------------------------------------\n");

			Console.Read();
		}
	}
}