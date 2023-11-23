
using System;
namespace ClassAssignment
{
	public class Math
	{


		public void Division(int number)
		{
			int result = number / 2;
			Console.WriteLine(result);
		}



		public void Output(out int Num1,out int Num2)
		{
			Num2 = 20;
			Num1 = 40;
		}


		public void Output(out decimal Num3, out decimal Num4, decimal Num5)
		{

			Num3 = 50.304m;
			Num4 = 60.532m;
			
		}
	}
}

