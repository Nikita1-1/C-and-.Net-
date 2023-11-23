namespace ClassAssignment;
class Program
{
    static void Main(string[] args)
    {
        Math integer = new Math();

        Console.WriteLine("Please Enter a Number that will be Divided by 2");
        int number = Convert.ToInt32(Console.ReadLine());
        integer.Division(number);



        int Num1;
        int Num2;
        integer.Output(out Num1, out Num2);
        Console.WriteLine("Num1: {0}", Num1);
        Console.WriteLine("Num2: {0}", Num2);


        decimal Num3;
        decimal Num4;
        decimal Num5 = 30.456m;

        integer.Output(out Num3, out Num4, Num5);
        Console.WriteLine("Num3: {0}", Num3);
        Console.WriteLine("Num4: {0}", Num4);
        Console.WriteLine("Num5: {0}", Num5);
        Console.ReadLine();
    }
}

