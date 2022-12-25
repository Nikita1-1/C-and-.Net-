namespace DataTime;
class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        now.ToString();
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("Enter Number");

        int useriInput = Convert.ToInt32(Console.ReadLine());

        DateTime future = now.AddHours(useriInput);
        Console.WriteLine(future);

        Console.ReadLine();
    }
}

