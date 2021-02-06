using System;
using System.IO;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// ファイル操作(FileInfo)
			Console.WriteLine("-------------ファイル操作(FileInfo)--------------");

			// オブジェクト生成(インスタンス化)
			var filePath = new FileInfo(@"C:\C#TIPS\TIPS_28\tips28.txt");

			// ファイル存在チェック
			Console.WriteLine($"ファイル存在チェック：{filePath.Exists}");

			// ファイル名取得
			Console.WriteLine($"ファイル名取得：{filePath.Name}");

			// フォルダ名取得
			Console.WriteLine($"フォルダ名取得：{filePath.DirectoryName}");

			// ファイルサイズ取得
			Console.WriteLine($"ファイルサイズ取得：{filePath.Length}");

			// ファイルの読み取り専用判定
			Console.WriteLine($"読み取り専用判定：{filePath.IsReadOnly}");

			// ファイルの最終更新日
			Console.WriteLine($"最終更新日：{filePath.LastWriteTime}");

			// ファイルコピー
			var filePath2 = filePath.CopyTo(@"C:\C#TIPS\TIPS_28\tips28_copy.txt");

			// ファイル移動
			filePath2.MoveTo(@"C:\C#TIPS\TIPS_28\test\tips28_copy.txt");

			// ファイル削除
			filePath2.Delete();

			Console.WriteLine("-------------------------------------------------");

			// フォルダ操作(DirectoryInfo)
			Console.WriteLine("----------フォルダ操作(DirectoryInfo)------------");

			// オブジェクト生成(インスタンス化)
			var folderPath = new DirectoryInfo(@"C:\C#TIPS\TIPS_28\NewFolder");
			var folderPath2 = new DirectoryInfo(@"C:\C#TIPS\TIPS_28\NewFolder2");

			// フォルダ作成
			folderPath.Create();
			folderPath2.Create();

			// サブフォルダ作成
			folderPath.CreateSubdirectory("subdir1");
			folderPath.CreateSubdirectory("subdir2");
			folderPath.CreateSubdirectory("subdir3");

			// フォルダ存在チェック
			Console.WriteLine($"フォルダ存在チェック：{folderPath.Exists}");

			// フォルダの作成日時
			Console.WriteLine($"作成日時：{folderPath.CreationTime}");

			// フォルダの最終更新日
			Console.WriteLine($"最終更新日：{folderPath.LastAccessTime}");

			// サブフォルダ一覧を取得
			var subFolders = folderPath.GetDirectories();
			foreach (var item in subFolders)
			{
				Console.WriteLine($"{item.FullName}");
			}

			// フォルダ移動
			folderPath.MoveTo(@"C:\C#TIPS\TIPS_28\test\NewFolder");

			// フォルダ削除
			folderPath2.Delete();

			Console.WriteLine("-------------------------------------------------");
			Console.Read();
		}
	}
}