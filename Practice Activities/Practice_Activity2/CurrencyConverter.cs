using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.Write("Enter amount in USD: ");
        double amountUSD = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter exchange rate from USD to EUR: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        
        double amountEUR = amountUSD*rate;
        
        Console.Write($"Amount in EUR: {amountEUR:F2}");
    }
}