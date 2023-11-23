using System;
namespace OPERATORS
{
	public class Employee<T>
	{
		public List<T> things { get; set;  }
		public int ID { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }

		public static Boolean operator ==(Employee<T> employee1, Employee<T> employee2)
		{
			if (employee1.ID == employee2.ID)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static Boolean operator !=(Employee<T> employee1, Employee<T> employee2)
		{
			if (employee1.ID != employee2.ID)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}


