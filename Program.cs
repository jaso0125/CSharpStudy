using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// if文 単純分岐
			string name = "じゃそ";
			Console.WriteLine($"------------if文 単純分岐------------\n");

			if (name == "じゃそ")
			{
				Console.WriteLine($"彼の名前はじゃそです。");
			}
			else
			{
				Console.WriteLine("彼の名前はじゃそではありません。");
			}
			Console.WriteLine($"\n-------------------------------------");

			// if文 多岐分岐
			Console.WriteLine($"\n------------if文 多岐分岐------------\n");

			string name2 = "松本潤";
			if (name2 == "じゃそ")
			{
				Console.WriteLine($"彼の名前はじゃそです。");
			}
			else if (name2 == "松本潤")
			{
				Console.WriteLine($"彼の名前は松本潤です。");
			}
			else
			{
				Console.WriteLine("彼の名前はじゃそでも松本潤でもありません。");
			}
			Console.WriteLine($"\n-------------------------------------");

			// if文 入れ子構造
			Console.WriteLine($"\n----------if文 入れ子構造------------\n");

			int i = 20;

			if (i <= 50)
			{
				if (i == 50)
				{
					Console.WriteLine("iは50である");
				}
				else
				{
					Console.WriteLine("iは50未満である");
				}
			}
			else
			{
				Console.WriteLine("iは50より大きい数字である");
			}
			Console.WriteLine($"\n-------------------------------------");

			Console.Read();
		}
	}
}