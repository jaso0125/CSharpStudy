using System;
using System.Collections.Generic;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// ハッシュセット(HashSet)
			var hashSet1 = new HashSet<int> { 2, 3, 5, 7 };
			var hashSet2 = new HashSet<int> { 1, 2, 3, 4 };

			// 要素追加(Add)
			Console.WriteLine("-----------------要素追加(Add)--------------------\n");
			hashSet1.Add(11);
			hashSet2.Add(6);

			Console.WriteLine("----------------hashSet1------------------");
			foreach (var item in hashSet1)
			{
				Console.WriteLine($"{item}");
				// 結果：2，3，5，7，11
			}

			Console.WriteLine("----------------hashSet2------------------");

			foreach (var item in hashSet2)
			{
				Console.WriteLine($"{item}");
				// 結果：1，2，3，4，6
			}

			Console.WriteLine("--------------------------------------------------\n");

			// 差集合(ExceptWith)
			Console.WriteLine("---------------差集合(ExceptWith)-----------------");
			var hs1 = new HashSet<int>(hashSet1);
			hs1.ExceptWith(hashSet2);

			foreach (var item in hs1)
			{
				Console.WriteLine($"{item}");
				// 結果：5，7，11
			}
			Console.WriteLine("--------------------------------------------------\n");

			// 和集合(UnionWith)
			Console.WriteLine("----------------和集合(UnionWith)-----------------");
			var hs2 = new HashSet<int>(hashSet1);
			hs2.UnionWith(hashSet2);

			foreach (var item in hs2)
			{
				Console.WriteLine($"{item}");
				// 結果：2，3，5，7，11, 1，4，6
			}
			Console.WriteLine("--------------------------------------------------\n");

			// 積集合(IntersectWith)
			Console.WriteLine("-------------積集合(IntersectWith)---------------");
			var hs3 = new HashSet<int>(hashSet1);
			hs3.IntersectWith(hashSet2);

			foreach (var item in hs3)
			{
				Console.WriteLine($"{item}");
				// 結果：2，3
			}
			Console.WriteLine("--------------------------------------------------\n");

			// 部分集合判定(IsSubsetOf)
			Console.WriteLine("------------部分集合判定(IsSubsetOf)--------------");
			Console.WriteLine(hashSet1.IsSubsetOf(hashSet2)); // 結果：false
			Console.WriteLine("--------------------------------------------------\n");

			// 上位集合判定(IsSupersetOf)
			Console.WriteLine("-----------上位集合判定(IsSupersetOf)-------------");
			Console.WriteLine(hashSet1.IsSupersetOf(hashSet2)); // 結果：false
			Console.WriteLine("--------------------------------------------------\n");

			// 共通の要素判定(Overlaps)
			Console.WriteLine("------------共通の要素判定(Overlaps)--------------");
			Console.WriteLine(hashSet1.Overlaps(hashSet2)); // 結果：true
			Console.WriteLine("--------------------------------------------------\n");

			// リストをクリア(Clear)
			Console.WriteLine("-------------リストをクリア(Clear)----------------");
			hashSet1.Clear();
			hashSet2.Clear();
			Console.WriteLine($"hashSet1の要素数は{hashSet1.Count}個です。");
			Console.WriteLine($"hashSet2の要素数は{hashSet2.Count}個です。");
			Console.WriteLine("--------------------------------------------------\n");

			// SortedSet
			Console.WriteLine("-------------------SortedSet----------------------");
			var sortedSet1 = new SortedSet<int> { 7, 5, 2, 3, 11 };

			foreach (var item in sortedSet1)
			{
				Console.WriteLine($"{item}");
				// 結果：2，3，5，7，11
			}
			Console.WriteLine("--------------------------------------------------\n");

			Console.Read();
		}
	}
}