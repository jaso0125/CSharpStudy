using System;
using System.IO;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// フォルダ作成(Directory.CreateDirectory)
			var folderPath = @"C:\C#TIPS\Tips27"; // フォルダ名「Tips27」

			Console.WriteLine("--------フォルダ作成(Directory.CreateDirectory)-------");

			if (!Directory.Exists(folderPath)) // フォルダが既に存在している場合、作成しない
			{
				Directory.CreateDirectory(folderPath);
				Console.WriteLine($"{folderPath}を作成しました。");
			}

			Console.WriteLine("------------------------------------------------------");

			//ファイル作成(File.Create)
			var filePath = @"C:\C#TIPS\tips27.txt"; // ファイル名「tips27.txt」

			Console.WriteLine("--------------ファイル作成(File.Create)---------------");

			if (!File.Exists(filePath)) // ファイルが既に存在している場合、作成しない
			{
				File.Create(filePath);
				Console.WriteLine($"{filePath}を作成しました。");
			}

			Console.WriteLine("------------------------------------------------------");

			// ファイルコピー(File.Copy)
			var copyfilePath = @"C:\C#TIPS\tips27.txt"; // コピー元ファイル名「tips27.txt」
			var createFilePath = @"C:\C#TIPS\tips27_copy.txt"; // コピー先ファイル名「tips27_copy.txt」

			Console.WriteLine("--------------ファイルコピー(File.Copy)---------------");

			if (File.Exists(copyfilePath)) // コピー元ファイルが既に存在する場合、コピーする
			{
				File.Copy(copyfilePath, createFilePath);
				Console.WriteLine($"{copyfilePath}を{createFilePath}という名前でコピーしました。");
			}

			Console.WriteLine("------------------------------------------------------");
			Console.Read();
		}
	}
}