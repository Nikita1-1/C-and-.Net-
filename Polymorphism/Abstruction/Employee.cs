using System;
namespace Abstruction
{
	public class Employee : Person, IQuittable
    {
        public override void sayName()
        {
            base.sayName();
        }

        public void Quit()
        {
            Console.WriteLine("I am tired, i quit");
        }
    }
}

