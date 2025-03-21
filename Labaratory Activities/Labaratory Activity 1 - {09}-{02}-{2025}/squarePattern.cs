using System;

class SquarePattern
{
    static void Main()
    {
        Console.Write("Enter n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.Write("Enter y: ");
            if (int.TryParse(Console.ReadLine(), out int y) && y > 0 && y <= n)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i == y)
                    {
                        Console.WriteLine();
                        continue;
                    }
                    
                    for (int j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid row number. Please enter a value between 1 and n.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer for n.");
        }
    }
}
