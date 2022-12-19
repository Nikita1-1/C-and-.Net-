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
        operation.Num1 = 20;
        int Num2 = 20;



        Console.WriteLine("please input number 1 and number 2, number 1 will do some math");
        


        Console.WriteLine(operation.Multiply(B));

        operation.twoIntegers(operation.Num1, Num2);


        operation.twoIntegers(Num1: 10, Num2: 10);

        Console.ReadLine();
    }
}

