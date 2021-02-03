using System;
using System.IO;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// ファイル/フォルダの削除(Delete)
			var filePath = @"C:\C#TIPS\file1.txt";
			var folderPath = @"C:\C#TIPS\folder1";

			Console.WriteLine("----------ファイル/フォルダの削除(Delete)-----------");

			// ファイル削除
			if (File.Exists(filePath)) // ファイル存在チェック
			{
				File.Delete(filePath);
				Console.WriteLine($"{filePath}を削除しました");
			}
			else
			{
				Console.WriteLine($"{filePath}が存在しません。");
			}

			// フォルダ削除
			if (Directory.Exists(folderPath)) // フォルダ存在チェック
			{
				Directory.Delete(folderPath);
				Console.WriteLine($"{folderPath}を削除しました");
			}
			else
			{
				Console.WriteLine($"{folderPath}が存在しません。");
			}
			Console.WriteLine("----------------------------------------------------");

			Console.WriteLine("-----------ファイル/フォルダの移動(Move)------------");
			//ファイル / フォルダの移動(Move)
			var filePath1 = @"C:\C#TIPS\text_1.txt"; // 移動元ファイル
			var desfilePath1 = @"C:\C#TIPS\folder_1\text_1.txt"; // 移動先ファイル
			var folderPath1 = @"C:\C#TIPS\folder_1"; // 移動元フォルダ
			var folderPath2 = @"C:\C#TIPS\folder_2\folder_1"; // 移動先フォルダ

			// ファイル移動
			if (File.Exists(filePath1)) // ファイル存在チェック
			{
				File.Move(filePath1, desfilePath1);
				Console.WriteLine($"{filePath1}を{desfilePath1}に移動しました");
			}
			else
			{
				Console.WriteLine($"ファイルを移動できませんでした。");
			}

			//フォルダ移動
			if (Directory.Exists(folderPath1)) // フォルダ存在チェック
			{
				Directory.Move(folderPath1, folderPath2);
				Console.WriteLine($"{folderPath1}を{folderPath2}に移動しました");
			}
			else
			{
				Console.WriteLine($"フォルダを移動できませんでした。");
			}
			Console.WriteLine("----------------------------------------------------");
			Console.Read();
		}
	}
}