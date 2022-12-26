namespace Constructor;
class Program
{
    static void Main(string[] args)
    {
        var newPerson = new InheritConstructor("Nikita");
        const string person = "Alex";
        Console.WriteLine(newPerson);


        Console.ReadLine();

    }
}

