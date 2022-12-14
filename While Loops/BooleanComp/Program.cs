namespace BooleanComp;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This is a do while and while loops");


        int num = 5;
        int count = 0;
        while (count < num)
        {
            Console.WriteLine(count += 1);
        }

        Console.WriteLine("Guess The Number");
        int guessed = Convert.ToInt32(Console.ReadLine());
        bool isGuessed = guessed == 17;


        do
        {
            switch (guessed)
            {
                case 10:
                    Console.WriteLine("You guessed the number");
                    Console.WriteLine("Guess The Number");
                    guessed = Convert.ToInt32(Console.ReadLine());
                    break;
                case 15:
                    Console.WriteLine("You guessed the number");
                    Console.WriteLine("Guess The Number");
                    guessed = Convert.ToInt32(Console.ReadLine());
                    break;
                case 17:
                    Console.WriteLine("You guessed the number");
                    isGuessed = true;
                    break;
            }
        }
        while (!isGuessed);

        Console.ReadLine();


        
    }
}

