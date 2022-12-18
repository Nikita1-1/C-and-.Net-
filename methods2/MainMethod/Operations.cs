using System;
namespace MainMethod
{
	public class Operations
	{
		public int A { set; get; }
		public int B { set; get; }
		public int C { set; get; }


		public int doSomething(int B)
		{
			return A - B;
		}


		public decimal doSomething(decimal C)
		{
			
			return A / C;
		}

		public string doSomething(string D)
		{
			return A + D;
		}

    }
}

