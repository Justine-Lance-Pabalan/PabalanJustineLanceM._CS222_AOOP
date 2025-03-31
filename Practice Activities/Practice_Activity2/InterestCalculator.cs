using System;

class InterestCalculator
{
    static void Main()
    {
        Console.Write("Enter principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());
        
        double interest = (principal*rate*time)/100;
        
        Console.Write($"Simple Interest: {interest:F2}");
    }
}