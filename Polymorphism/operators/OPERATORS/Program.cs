namespace OPERATORS;
class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee();
        Employee employee2 = new Employee();
        employee1.ID = 1;
        employee1.firstName = "Nikita";
        employee1.lastName = "Sazonov";
        employee2.ID = 2;
        employee2.firstName = "Andy";
        employee2.lastName = "Smith";

        if (employee1 == employee2)
        {
            Console.WriteLine("Emplyees are equal");
        }
        else
        {
            Console.WriteLine("Emplyees are not equal");
        }

        if (employee1 != employee2)
        {
            Console.WriteLine("Emplyees are not equal");
        }
        else
        {
            Console.WriteLine("Emplyees are equal");
        }

        Console.ReadLine();
        
    }
}

