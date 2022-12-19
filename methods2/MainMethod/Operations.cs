using System;
namespace MainMethod
{
	public class Operations
	{
		public int A { set; get; }
		public int B { set; get; }
		public int C { set; get; }
		public int D { set; get; }

		public int doSomething(int B)
		{
			return A + B;
		}


		public int doSomething( decimal C)
		{
            int K = Convert.ToInt32(C);
            return K / A;
		}

		public int doSomething(string D)
		{
			int S = Convert.ToInt32(D);
			return S + A;
		}

	}
}

