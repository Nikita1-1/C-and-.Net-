namespace Lambda;
class Program
{
    static void Main(string[] args)
    {

        Employee employee = new Employee();
        List<Employee> Names = new List<Employee>
        {
        new Employee{ ID = 1, FirstName = "Nikita", LastName = "Sazonov"},
        new Employee{ ID = 2, FirstName = "Joe", LastName = "Smith" },
        new Employee{ ID = 3, FirstName = "John", LastName = "Johonson"},
        new Employee{ ID = 4, FirstName = "William", LastName = "Prior"},
        new Employee{ ID = 5, FirstName = "Makenzee", LastName = "Lee"},
        new Employee{ ID = 6, FirstName = "Joe", LastName = "Jonson"},
        new Employee{ ID = 7, FirstName = "Anali", LastName = "Lome"},
        new Employee{ ID = 8, FirstName = "Iseas", LastName = "Sole" }
        };

        List<Employee> joe = new List<Employee>();

        foreach (Employee name in Names)
        {
            if (name.FirstName == "Joe")
            {
                joe.Add(new Employee
                {
                    ID = name.ID,
                    FirstName = name.FirstName,
                    LastName = name.LastName
                });
            }
        }


        foreach (Employee nameJoe in joe)
        {
            Console.WriteLine("{0} {1} {2}", nameJoe.FirstName, nameJoe.LastName, nameJoe.ID);
        }


        List<Employee> newlist = Names.Where(x => x.FirstName == "Joe").ToList();

        foreach (Employee j in newlist)
        {
            Console.WriteLine("{0} {1} {2}", j.FirstName, j.LastName, j.ID);
        }


        List<Employee> idList = Names.Where(x => x.ID > 5).ToList();
        foreach (Employee k in idList)
        {
            Console.WriteLine("{0} {1} {2}", k.FirstName, k.LastName, k.ID);
        }

        //Console.WriteLine(joe);
        Console.ReadLine();
    }
}
