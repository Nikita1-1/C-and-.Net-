namespace CarInsuranceApp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is Your Age?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Have you ever had a DUI?");
        string DUI = Console.ReadLine();
        if (DUI == "yes")
        {
            // raise arror if user has dui
            throw new KeyNotFoundException("You cannot have DL if you have DUI");
        }

        Console.WriteLine("How Many Speeding Tickets Do You Have?");
        int tickets = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qualified?");

        if (age > 15 && DUI == "no" && tickets < 3)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);

        }
        Console.ReadLine();
    }
}

