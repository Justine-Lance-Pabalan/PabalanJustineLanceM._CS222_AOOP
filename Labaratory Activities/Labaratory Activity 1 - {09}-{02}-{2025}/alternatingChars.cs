using System;

class AlternatingChars
{
    static void Main()
    {
        Console.Write("First character: ");
        char firstChar = Console.ReadLine()[0];

        Console.Write("Second character: ");
        char secondChar = Console.ReadLine()[0];

        Console.Write("Enter size: ");
        if (int.TryParse(Console.ReadLine(), out int size) && size > 0)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(new string('-', i));

                if (i % 2 == 0)
                    Console.WriteLine(firstChar);
                else
                    Console.WriteLine(secondChar);
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for size.");
        }
    }
}
