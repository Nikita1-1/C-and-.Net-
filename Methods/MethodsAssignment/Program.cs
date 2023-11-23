namespace MethodsAssignment;
class Program
{
    static void Main()
    {
        Math math = new Math();
        Console.WriteLine("Please choose any number that you would like to do some math operation on: Division, Sum, Multiply ?");
        try
        {
            math.A = Convert.ToInt32(Console.ReadLine());
            math.B = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(math.Multiply());
            Console.WriteLine(math.Division());
            Console.WriteLine(math.Summ());

        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You cannot input 0");
        }
        catch (FormatException)
        {
            Console.WriteLine("Please use whole numbers, not a text or numbers with point");
        }
       
        Console.ReadLine();
    }
}

