using System;
using System.IO;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// テキストファイルの読み込み
			using (var file = new StreamReader(@"C:\C#TIPS\TIPS_31\コーヒーブレイク1.txt"))
			{
				// テキストファイルを一度に読み込む(ReadToEnd)
				//Console.WriteLine(file.ReadToEnd());
				//Console.Read();

				// テキストファイルを1行ずつ読み込む(ReadLine)
				//Console.WriteLine(file.ReadLine());

				// テキストファイルを1行ずつ読み込む、最後まで読み込む(ReadLine))
				while (!file.EndOfStream) // 末尾かどうかを判定
				{
					Console.WriteLine(file.ReadLine());
				}
				Console.Read();
			}
		}
	}
}