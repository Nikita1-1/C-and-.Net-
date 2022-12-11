using System.Numerics;

namespace VariablesAndDataTypes;
class Program
{
    static void Main(string[] args)
    {
        // Welcome Text
        Console.WriteLine("The Tech Academy");
        Console.WriteLine("Student Daily Report");

        // Questions is peresenting in console and taking the an input from a student
        Console.WriteLine("What is your name? ");
        string studentName = Console.ReadLine();
        Console.WriteLine("What course are you on? ");
        string course = Console.ReadLine();
        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        // converting answer into integer
        int pageNum = Convert.ToInt32(pageNumber);
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
        string help = Console.ReadLine();
        //converting answer into boolean otherwise it will raise an error if user write something different from true or false
        bool isHelp = Convert.ToBoolean(help);
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string experience = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hours = Console.ReadLine();
        int hoursStudy = Convert.ToInt32(hours);
        Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

    }
}

