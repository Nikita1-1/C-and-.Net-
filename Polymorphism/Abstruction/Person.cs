using System;
namespace Abstruction
{
	public abstract class Person
	{
		public string firstName { get; set; }
		public string lastName { get; set; }




		public virtual void sayName()
		{
			Console.WriteLine("full name: {0} {1}", firstName, lastName);
		}
	}
}

