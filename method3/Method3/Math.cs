using System;
namespace Method3
{
	public class Math
	{
		public int A { get; set; }
		public int B { get; set; }




		public int Multiply(int B)
		{
            if (B == 0 || B == null)
            {
                int C = 2;
                return A * C;
            }
            return A * B;
		}
	}
}

