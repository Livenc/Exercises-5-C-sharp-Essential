using System.Collections.Generic;

namespace Exercise_6;
class Program
{
    static void Main(string[] args)
    {
        Dictionary dictionary = new Dictionary();

        Console.WriteLine(dictionary["книга"]);
        Console.WriteLine(dictionary["home"]);
        Console.WriteLine(dictionary["ручка"]);
        Console.WriteLine(dictionary["стол"]);
        Console.WriteLine(dictionary["карандаш"]);
        Console.WriteLine(dictionary["apple"]);
        Console.WriteLine(dictionary["table"]);

        Console.WriteLine(new string('-', 20));

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(dictionary[i]);
        }

        // Delay.
        Console.ReadKey();
    }
}

