namespace CSharp
{
	public class Program
	{
		private static void Main(string[] args)
		{
			var car = new Car(); // Carクラスによるインスタンス化

			car.CarColor = "Blue"; // プロパティの設定
			car.Run(); // メソッドの実行
		}
	}

	// 車クラス
	public class Car
	{
		public string _carColor; // フィールドの定義

		public string CarColor // プロパティの定義
		{
			get => _carColor;
			set => _carColor = value;
		}

		public Car() // コンストラクターの定義
		{
			// インスタンス化時に最初に呼ばれる
		}

		public void Run() // メソッドの定義
		{
		}
	}
}