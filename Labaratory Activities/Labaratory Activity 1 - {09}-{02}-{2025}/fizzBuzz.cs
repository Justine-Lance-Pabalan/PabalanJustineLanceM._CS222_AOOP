using System;

class FizzBuzz
{
    static void Main()
    {
        Console.Write("Enter upper bound: ");
        
        if (int.TryParse(Console.ReadLine(), out int upperBound) && upperBound > 0)
        {
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
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }
}