using System;

namespace CSharp
{
	public class Program
	{
		private static void Main(string[] args)
		{
			Car Jimny = new Car("ジムニー");
			Car Demio = new Car("デミオ");

			Console.WriteLine($"車の高さ：{Jimny.CarHeight}");
			Console.WriteLine($"車の幅  ：{Jimny.CarWidth}");
			Console.WriteLine($"車の色  ：{Jimny.CarColor}");
			Jimny.Run("ジムニー");
			Jimny.Stop("ジムニー");
			Jimny.BeepHorn("ジムニー");

			Console.WriteLine($"車の高さ：{Demio.CarHeight}");
			Console.WriteLine($"車の幅  ：{Demio.CarWidth}");
			Console.WriteLine($"車の色  ：{Demio.CarColor}");
			Demio.Run("デミオ");
			Demio.Stop("デミオ");
			Demio.BeepHorn("デミオ");

			Console.WriteLine($"\n-----配列の宣言-----");
			// 初期値を定義した宣言
			// データ型[] 配列名 = { 要素1, 要素2,・・・ }
			string[] fruits = { "バナナ", "オレンジ", "りんご", "メロン" };
			Console.WriteLine($"fruits[0]： {fruits[0]} ");
			Console.WriteLine($"fruits[1]： {fruits[1]} ");
			Console.WriteLine($"fruits[2]： {fruits[2]} ");
			Console.WriteLine($"fruits[3]： {fruits[3]} ");
			Console.WriteLine($"--------------------");
			Console.Read();
		}
	}

	// 車クラス
	public class Car
	{
		// 車の高さ
		public double CarHeight { get; set; }

		// 車の幅
		public double CarWidth { get; set; }

		// 車の色
		public string CarColor { get; set; }

		// コンストラクタ
		public Car(string type)
		{
			if (type == "ジムニー")
			{
				CarHeight = 1.65;
				CarWidth = 1.48;
				CarColor = "Black";
			}
			if (type == "デミオ")
			{
				CarHeight = 1.5;
				CarWidth = 1.68;
				CarColor = "Blue";
			}
		}

		// 車を走らせるメソッド
		public void Run(string carName)
		{
			Console.WriteLine($"{carName}走ります！");
		}

		// 車を止めるメソッド
		public void Stop(string carName)
		{
			Console.WriteLine($"{carName}止まります！");
		}

		// クラクションを鳴らすメソッド
		public void BeepHorn(string carName)
		{
			Console.WriteLine($"{carName}クラクション鳴らします！");
		}
	}
}