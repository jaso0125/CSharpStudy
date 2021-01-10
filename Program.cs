using System;

namespace CSharp
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// sbyteの暗黙的変換
			Console.WriteLine("-----sbyteの暗黙的変換-----");
			sbyte sbyteNum = -128;
			short shortNum = sbyteNum;
			int intNum = sbyteNum;
			long longNum = sbyteNum;
			float floatNum = sbyteNum;
			double doubleNum = sbyteNum;
			Console.WriteLine($"sbyteNum ：{sbyteNum}");
			Console.WriteLine($"shortNum ：{shortNum}");
			Console.WriteLine($"intNum   ：{intNum}");
			Console.WriteLine($"longNum  ：{longNum}");
			Console.WriteLine($"floatNum ：{floatNum}");
			Console.WriteLine($"doubleNum：{doubleNum}");
			Console.WriteLine("---------------------------");

			// byteの暗黙的変換
			Console.WriteLine("-----byteの暗黙的変換------");
			byte byteNum = 255;
			shortNum = byteNum;
			ushort ushortNum = byteNum;
			intNum = byteNum;
			uint uintNum = byteNum;
			longNum = byteNum;
			floatNum = byteNum;
			doubleNum = byteNum;
			decimal decimalNum = byteNum;
			Console.WriteLine($"byteNum   ：{byteNum}");
			Console.WriteLine($"ushortNum ：{ushortNum}");
			Console.WriteLine($"intNum    ：{intNum}");
			Console.WriteLine($"uintNum   ：{uintNum}");
			Console.WriteLine($"longNum   ：{longNum}");
			Console.WriteLine($"floatNum  ：{floatNum}");
			Console.WriteLine($"doubleNum ：{doubleNum}");
			Console.WriteLine($"decimalNum：{decimalNum}");
			Console.WriteLine("---------------------------");

			//shortの暗黙的変換
			Console.WriteLine("-----shortの暗黙的変換-----");
			shortNum = -32768;
			intNum = shortNum;
			longNum = shortNum;
			floatNum = shortNum;
			doubleNum = shortNum;
			decimalNum = shortNum;
			Console.WriteLine($"shortNum   ：{shortNum}");
			Console.WriteLine($"intNum     ：{intNum}");
			Console.WriteLine($"longNum    ：{longNum}");
			Console.WriteLine($"floatNum   ：{floatNum}");
			Console.WriteLine($"doubleNum  ：{doubleNum}");
			Console.WriteLine($"decimalNum ：{decimalNum}");
			Console.WriteLine("---------------------------");

			// ushortの暗黙的変換
			Console.WriteLine("----ushortの暗黙的変換-----");
			ushortNum = 65535;
			intNum = ushortNum;
			uintNum = ushortNum;
			longNum = ushortNum;
			ulong ulongNum = ushortNum;
			floatNum = ushortNum;
			doubleNum = ushortNum;
			decimalNum = ushortNum;
			Console.WriteLine($"ushortNum ：{ushortNum}");
			Console.WriteLine($"intNum    ：{intNum}");
			Console.WriteLine($"uintNum   ：{uintNum}");
			Console.WriteLine($"longNum   ：{longNum}");
			Console.WriteLine($"ulongNum  ：{ulongNum}");
			Console.WriteLine($"floatNum  ：{floatNum}");
			Console.WriteLine($"doubleNum ：{doubleNum}");
			Console.WriteLine($"decimalNum：{decimalNum}");
			Console.WriteLine("---------------------------");

			// intの暗黙的変換
			Console.WriteLine("------intの暗黙的変換------");
			intNum = -2147483648;
			longNum = intNum;
			floatNum = intNum;
			doubleNum = intNum;
			decimalNum = intNum;
			Console.WriteLine($"intNum    ：{intNum}");
			Console.WriteLine($"longNum   ：{longNum}");
			Console.WriteLine($"floatNum  ：{floatNum}");
			Console.WriteLine($"doubleNum ：{doubleNum}");
			Console.WriteLine($"decimalNum：{decimalNum}");
			Console.WriteLine("---------------------------");

			// uintの暗黙的変換
			Console.WriteLine("-----uintの暗黙的変換------");
			uintNum = 4294967295;
			longNum = uintNum;
			ulongNum = uintNum;
			floatNum = uintNum;
			doubleNum = uintNum;
			decimalNum = uintNum;
			Console.WriteLine($"uintNum    ：{uintNum}");
			Console.WriteLine($"longNum    ：{longNum}");
			Console.WriteLine($"ulongNum   ：{ulongNum}");
			Console.WriteLine($"floatNum   ：{floatNum}");
			Console.WriteLine($"doubleNum  ：{doubleNum}");
			Console.WriteLine($"decimalNum ：{decimalNum}");
			Console.WriteLine("---------------------------");

			// longの暗黙的変換
			Console.WriteLine("-----longの暗黙的変換------");
			longNum = -9223372036854775808;
			floatNum = longNum;
			doubleNum = longNum;
			decimalNum = longNum;
			Console.WriteLine($"longNum    ：{longNum}");
			Console.WriteLine($"floatNum   ：{floatNum}");
			Console.WriteLine($"doubleNum  ：{doubleNum}");
			Console.WriteLine($"decimalNum ：{decimalNum}");
			Console.WriteLine("---------------------------");

			// charの暗黙的変換
			Console.WriteLine("-----charの暗黙的変換------");
			char charNum = 'A';
			ushortNum = charNum;
			intNum = charNum;
			uintNum = charNum;
			longNum = charNum;
			ulongNum = charNum;
			floatNum = charNum;
			doubleNum = charNum;
			decimalNum = charNum;
			Console.WriteLine($"charNum   ：{charNum}→10進数で表現すると65になる");
			Console.WriteLine($"ushortNum ：{ushortNum}");
			Console.WriteLine($"intNum    ：{intNum}");
			Console.WriteLine($"uintNum   ：{uintNum}");
			Console.WriteLine($"longNum   ：{longNum}");
			Console.WriteLine($"ulongNum  ：{ulongNum}");
			Console.WriteLine($"floatNum  ：{floatNum}");
			Console.WriteLine($"doubleNum ：{doubleNum}");
			Console.WriteLine($"decimalNum：{decimalNum}");
			Console.WriteLine("---------------------------");

			// ulongの暗黙的変換
			Console.WriteLine("----ulongの暗黙的変換------");
			ulongNum = 18446744073709551615;
			floatNum = ulongNum;
			doubleNum = ulongNum;
			decimalNum = ulongNum;
			Console.WriteLine($"ulongNum  ：{ulongNum}");
			Console.WriteLine($"floatNum  ：{floatNum}");
			Console.WriteLine($"doubleNum ：{doubleNum}");
			Console.WriteLine($"decimalNum：{decimalNum}");
			Console.WriteLine("---------------------------");

			// 明示的変換(キャスト)
			int iNum = 100;
			byte bNum = (byte)iNum; // エラーは発生しない
			Console.WriteLine("--------明示的変換---------");
			Console.WriteLine($"intNum   ：{iNum}");
			Console.WriteLine($"byteNum  ：{bNum}");
			Console.WriteLine("---------------------------");

			// 文字列を数値に変換
			string srtIntnum = "100";
			string strFloatNum = "1.2345";
			string strDoubleNum = "3.14";
			Console.WriteLine("------文字列数値変換-------");
			Console.WriteLine("------文字列数値変換-------");
			Console.WriteLine($"int変換   ：{int.Parse(srtIntnum)}");  // int型：100
			Console.WriteLine($"float変換 ：{float.Parse(strFloatNum)}"); //float型：1.2345
			Console.WriteLine($"double変換：{double.Parse(strDoubleNum)}"); // double型：3.14
			Console.WriteLine("---------------------------");

			// 数値を文字列に変換
			int num = 100;
			float fNum = 1.2345f;
			double dNum = 3.14;
			Console.WriteLine("------数値文字列変換-------");
			Console.WriteLine($"int文字列変換   ：{num.ToString()}"); //string型 "100"
			Console.WriteLine($"float文字列変換 ：{fNum.ToString()}"); //string型 "1.2345"
			Console.WriteLine($"double文字列変換：{dNum.ToString()}"); //string型 "3.14"
			Console.WriteLine("---------------------------");
			Console.Read();
		}
	}
}