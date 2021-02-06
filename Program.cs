using System.IO;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// テキストファイルの書き込み
			using (var text = new StreamWriter(@"C:\C#TIPS\TIPS_30\text.txt", true))
			{
				text.WriteLine("こんにちは");
			}
		}
	}
}