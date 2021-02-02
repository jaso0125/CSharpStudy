using System.IO; // usingディレクティブ使ってライブラリを宣言
using System;

namespace CSharp
{
	public class Program
	{
		private static void Main(string[] args)
		{
			var folderPath = @"C:\C#TIPS\"; // フォルダーが存在するパス
			var filePath = @"C:\C#TIPS\file1.txt"; // ファイルが存在するパス

			// フォルダの存在確認(Directory.Exists)
			Console.WriteLine("------------Directory.Exists-------------");
			if (Directory.Exists(folderPath))
			{
				Console.WriteLine("フォルダが見つかりました！");
			}
			else
			{
				Console.WriteLine("フォルダが存在しません。");
			}
			Console.WriteLine("-----------------------------------------");

			// ファイルの存在確認(File.Exists)
			Console.WriteLine("---------------File.Exists---------------");
			if (File.Exists(filePath))
			{
				Console.WriteLine("ファイルが見つかりました！");
			}
			else
			{
				Console.WriteLine("ファイルが存在しません。");
			}
			Console.WriteLine("-----------------------------------------");
			Console.Read();
		}
	}
}