using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfChocolate, priceOfRose, priceOfBattery;
            priceOfChocolate = int.Parse(Console.ReadLine());
            priceOfRose = int.Parse(Console.ReadLine());
            priceOfBattery = int.Parse(Console.ReadLine());

            int priceTotal = priceOfChocolate + priceOfRose + priceOfBattery;

            if (priceTotal <= 10)
                Console.WriteLine("Novcanica od 10");
            else if(priceTotal <= 20)
                Console.WriteLine("Novcanica od 20");
            else if (priceTotal <= 50)
                Console.WriteLine("Novcanica od 50");
            else if (priceTotal <= 100)
                Console.WriteLine("Novcanica od 100");
        }
    }
}
