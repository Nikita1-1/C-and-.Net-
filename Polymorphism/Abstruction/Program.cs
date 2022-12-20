namespace Abstruction;
class Program
{
    static void Main(string[] args)
    {
        Employee person = new Employee();
        person.firstName = "Sample";
        person.lastName = "Student";


        person.sayName();




        IQuittable quit = new Employee();

        quit.Quit();


        Console.ReadLine();
    }
}

