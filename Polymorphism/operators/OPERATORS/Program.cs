namespace OPERATORS;
class Program
{
    static void Main(string[] args)
    {
        Employee<string> employee = new Employee<string>();
        employee.things = new List<string>() { "engeneer", "waiter", "sale associate", "instructor", "programmer" };
        Employee<int> empl = new Employee<int>();
        empl.things = new List<int>() { 1, 2, 3, 4, 5 };
        Employee<string> employee1 = new Employee<string>();
        Employee<string> employee2 = new Employee<string>();
        
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

        foreach (string item in employee.things)
        {
            foreach (int number in empl.things)
            {
                Console.WriteLine(item, number);
            }
        }
        Console.ReadLine();
        
    }
}

