namespace MainMethod;
class Program
{
    static void Main(string[] args)
    {
        Operations operation = new Operations();
        int B = 5;
        Console.WriteLine("Please Insert Number That You Want To Divide by 10");
        decimal C = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Please Insert Number That You Want To Add to 10");
        int D = Convert.ToInt32(Console.ReadLine());

        operation.A = 10;
        



        Console.WriteLine(operation.doSomething(B));
       
        Console.WriteLine(operation.doSomething(C));
        Console.WriteLine(operation.doSomething(D));

        Console.ReadLine();
    }
}

