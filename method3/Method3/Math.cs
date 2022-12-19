using System;
namespace Method3
{
	public class Math
	{
		public int A { get; set; }
		public int B { get; set; }
		
		public int Num2 { get; set; }
		public int Num1 { get; set; }



		public int Multiply(int B)// if B is 0 then default 2 will be applied 
		{
            if (B == 0 || B == null)
            {
                int C = 2;
                return A * C;
            }
            return A * B;
		}


		public void twoIntegers(int Num1, int Num2)
		{

			Console.WriteLine(Num2);
			Console.WriteLine(Num1 - 1);
			
		}
	}
}

