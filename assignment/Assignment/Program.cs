using System.Diagnostics.Metrics;

namespace Assignment;
class Program
{
    static void Main(string[] args)
    {
        //string[] array = new string[5];
        //Console.WriteLine("Enter Text");
        //for (int i = 0; i < array.Length; i++)
        //{
        //    array[i] = Console.ReadLine();

        //}

        //foreach (string arr in array)
        //{
        //    Console.WriteLine(arr);
        //}


        //int number = 5;
        //int zero = 0;
        ////this while loop will be infinite because number  will never be != 4 because number = 5
        ////while (number != 4)
        //// to change it we need to make this consiton comlete

        //while( zero <= number)
        //{
        //    Console.WriteLine(zero);
        //    zero++;
        //    //Console.WriteLine("Infinite Loop");
        //}

        //int a = 10;
        //int z = 0;
        //while (z < a)
        //{
        //    Console.WriteLine(z);
        //    z++;
        //}

        //List<string> fruits = new List<string> {"apple", "strawberry", "banana", "blueberry", "dragonfruit", "orange", "mandarin"};
        //Console.WriteLine("What Fruit Do You Like? Let's see if we have it in our list");
        //string userFruit = Console.ReadLine();

        //for (int k = 0; k < fruits.Count; k++)
        //{
        //    if (fruits[k] == userFruit)
        //    {
        //        Console.WriteLine("Yes, we have " + userFruit + " at the index number " + k);
        //        break;
        //    }


        //}
        //if (!fruits.Contains(userFruit))
        //{
        //    Console.WriteLine("Sorry no match found");
        //}



        //List<string> cars = new List<string> { "huyndai", "ford", "range rover", "toyota", "ford" };
        //int count = 0;
        //Console.WriteLine("Please select any of this car producer names: huyndai, ford, range rover, toyota to see if any of the name is repeating itself?");
        //string doubleName = Console.ReadLine();

        //for (int l = 0; l < cars.Count; l++)
        //{
        //    if (cars[l] == doubleName)
        //    {
        //        Console.WriteLine("Name you selected exist with indexes " + l);
        //        count++;

        //    }

        //}
        //Console.WriteLine("Text that you entered met " + count + " times");
        //if (!cars.Contains(doubleName))
        //{
        //    Console.WriteLine("There is no such a name that repeats itself");
        //}



        List<string> letters = new List<string> { "a", "b", "c", "d", "a", "e", "f", "b" };
        List<string> duplicates = new List<string> { };

        foreach (string letter in letters)
        {
            int count = 0;

            foreach (string i in letters)
            {
                if (letter == i)
                {
                    count++;
                    if (count > 1)
                    {
                        if (!duplicates.Contains(i))
                        {
                            letters.Remove(i);
                            duplicates.Add(i);


                        }
                    }
                }
            }
        Console.WriteLine(letter + " - is unique");

        }
        foreach (string dupl in duplicates)
        {
            Console.WriteLine(dupl + " - is not unique");
        }

        Console.ReadLine();

    }
}

