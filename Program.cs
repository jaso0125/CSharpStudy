namespace CSharp
{
	public class Program
	{
		private static void Main(string[] args)
		{
			var car1 = new Car();

			car1.carHeight = 1.65;
			car1.carWidth = 1.48;
			car1.carColor = "Red"; // privateなのでエラーが発生する
		}
	}

	public class Car
	{
		// 車の高さ
		public double carHeight;

		// 車の幅
		public double carWidth;

		// 車の色
		private string carColor;
	}
}