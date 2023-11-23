using System;
namespace inheritance
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }


		public void SayName()
		{
			Console.WriteLine("Full Name: {0} {1}", FirstName, LastName);
		}

	}
}

