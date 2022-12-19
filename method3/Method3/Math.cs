using System;
namespace Method3
{
	public class Math
	{
		public int A { get; set; }
		public int B { get; set; }

        public int Num2 { get; set; }
		public int Num1 { get; set; }



		public int Multiply(int A, int B = 10)// if B is 0 then default 2 will be applied 
		{
			return A * B;
		}


		// Page assignment #281

		public void twoIntegers(int Num1, int Num2)
		{

			Console.WriteLine(Num2);
			Console.WriteLine(Num1 - 1);
			
		}
	}
}

