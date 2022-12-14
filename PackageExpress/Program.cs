namespace PackageExpress;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
        Console.WriteLine("What is the weight of your package?");
        int weight = Convert.ToInt32(Console.ReadLine());
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day");
            
        }
        else
        {
            Console.WriteLine("Package Width?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package Lenght?");
            int lenght = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Package Height?");
            int heigth = Convert.ToInt32(Console.ReadLine());

            int total = (lenght + heigth + width);
            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express. Have a good day");
            }
            else
            {
                decimal money = 100;
                decimal quote = ((lenght * heigth * width) * weight) / money;
                Console.WriteLine("Your estimated total for shipping this package is:" + "$" + quote);
            }
        }
        
        Console.ReadLine();
    }
}

