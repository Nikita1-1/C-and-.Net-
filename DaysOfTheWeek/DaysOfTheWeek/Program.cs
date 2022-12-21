using System.Drawing;
using static DaysOfTheWeek.Days;

namespace DaysOfTheWeek;
class Program
{
    static void Main(string[] args)
    {
        // try catch block that is going to catch any errors or wrong input 
        try
        {

            // asking user to input day of the week to compare to one in enum
            Console.WriteLine("please enter current day of the week");
            string day = Console.ReadLine();



            // variable with enum type that is parsing enum and takes the value of that if user input is correct and return it
            allDays dayValue = (allDays)Enum.Parse(typeof(allDays), day);


            
            
            Console.WriteLine(dayValue);


        }
        catch (FormatException)
        {
            // if there was an error(lower case input) then catch block is presenting this message
            Console.WriteLine("Please Enter actual day");
        }
        catch 
        {
            Console.WriteLine("Please Enter actual day");
        }
       
        
        

        Console.ReadLine();
    }
}

