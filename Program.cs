namespace AnonymousIncomeComparisonProgram;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Anonymous Income Comparison Program");

        Console.WriteLine(" Person 1");

        Console.WriteLine("What is your hourly rate?");
        string hr = Console.ReadLine();
        decimal rate = Convert.ToDecimal(hr);

        Console.WriteLine("How Many Hours Did You Work This Week?");
        string hours = Console.ReadLine();
        int weeklyHours = Convert.ToInt32(hours);


        Console.WriteLine(" Person 2");

        Console.WriteLine("What is your hourly rate?");
        string hourlyrate = Console.ReadLine();
        decimal hrate = Convert.ToDecimal(hourlyrate);

        Console.WriteLine("How Many Hours Did You Work This Week?");
        string hs = Console.ReadLine();
        int wh = Convert.ToInt32(hs);
        
        decimal weeklypay = rate * weeklyHours;
        decimal yearS = weeklypay * 52;

        decimal wp = hrate * wh;
        decimal yS = wp * 52;


        Console.WriteLine("Annual salary of Person 1: " + yearS);
        Console.WriteLine("Annual salary of Person 2: " + yS);


        Console.WriteLine("Does Person 1 make more money than Person 2?");
        if ( yearS > yS)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }

        Console.ReadLine();

    }
}
