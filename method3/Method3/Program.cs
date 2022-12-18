namespace Method3;
class Program
{
    static void Main(string[] args)
    {
        Math operation = new Math();

        Console.WriteLine("please input whole number that is going to multiply by 10");
        Console.WriteLine("if you insert 0, 10 will be multiply by 10 automaticly");
        int B = Convert.ToInt32(Console.ReadLine());

        operation.A = 10;

        
        Console.WriteLine(operation.Multiply(B));

        Console.ReadLine();
    }
}

