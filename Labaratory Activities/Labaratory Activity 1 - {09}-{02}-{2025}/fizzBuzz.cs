using System;

class Program
{
    static void Main()
    {
        int upperBound = 15; // Change this value if needed

        for (int i = 1; i <= upperBound; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}
