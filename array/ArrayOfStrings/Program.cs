namespace ArrayOfStrings;
class Program
{
    static void Main(string[] args)
    {
        string[] Array = { "hello", "world", "this", "is", "string" };
        Console.WriteLine("Choose any number between 0-4");
        int index = Convert.ToInt32(Console.ReadLine());
        if (index < 0 || index > 4)
        {
            Console.WriteLine("There is no such a number");
        }
        else
        {
            Console.WriteLine(Array[index]);
        }

        int[] Array2 = { 1,2,3,4,5 };
        Console.WriteLine("Choose any number between 0-4");
        int index2 = Convert.ToInt32(Console.ReadLine());
        if (index2 < 0 || index2 > 4)
        {
            Console.WriteLine("There is no such a number");
        }
        else
        {
            Console.WriteLine(Array2[index2]);
        }


        List<string> carsRange = new List<string> { "Mustang", "McLaren", "Buggati", "Pegoe" };
        Console.WriteLine("Choose any number between 0-3");
        int index3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(carsRange[index3]);

        Console.ReadLine();
        }
}

