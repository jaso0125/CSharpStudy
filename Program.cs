using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// while文
			int i = 0;
			Console.WriteLine($"-------------while文-------------");
			while (i < 10)
			{
				Console.WriteLine(i); // 0,1,2,3,4,5,6,7,8,9を出力
				i++;
			}
			Console.WriteLine($"---------------------------------");

			// do while文
			Console.WriteLine($"----------do-while文-------------");
			i = 0;
			do
			{
				Console.WriteLine(i); // 0,1,2,3,4,5,6,7,8,9を出力
				i++;
			}
			while (i < 10);

			Console.WriteLine($"---------------------------------");
			Console.Read();
		}
	}
}