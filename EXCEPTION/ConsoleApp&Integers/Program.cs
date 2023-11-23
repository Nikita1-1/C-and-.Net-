namespace ConsoleApp_Integers;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 10, 20, 30, 45, 56, 68, 72, 81, 92 };
        Console.WriteLine("Please input only whole number");
        try
        {
            int userInput = Convert.ToInt32(Console.ReadLine());

            foreach (int item in numbers)
            {
                int division = item / userInput;
                Console.WriteLine(division);
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please Enter Number Not A String (Text) Value");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Something Went Wrong, Please try again");
        }
        Console.ReadLine();

        }
    }

   
