using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1

            /*
            int priceOfChocolate, priceOfRose, priceOfBattery;
            priceOfChocolate = int.Parse(Console.ReadLine());
            priceOfRose = int.Parse(Console.ReadLine());
            priceOfBattery = int.Parse(Console.ReadLine());

            int priceTotal = priceOfChocolate + priceOfRose + 3 * priceOfBattery;


            if (priceTotal <= 10)
                Console.WriteLine("Novcanica od 10");
            else if(priceTotal <= 20)
                Console.WriteLine("Novcanica od 20");
            else if (priceTotal <= 50)
                Console.WriteLine("Novcanica od 50");
            else if (priceTotal <= 100)
                Console.WriteLine("Novcanica od 100");
            */

            //Task 2

            /*
            var busyStart = int.Parse(Console.ReadLine());
            var busyEnd = int.Parse(Console.ReadLine());
            var offeredTime1 = int.Parse(Console.ReadLine());
            var offeredTime2 = int.Parse(Console.ReadLine());

            
            if (offeredTime1 < busyStart || offeredTime1 > busyEnd)
                Console.WriteLine(offeredTime1);
            else if (offeredTime2 < busyStart || offeredTime2 > busyEnd)
                Console.WriteLine(offeredTime2);
            else
                Console.WriteLine("Nijedan termin ne odgovara");
            */

            //broj.ToString();

            var number = Console.ReadLine();

            Console.WriteLine(ReverseNumber(number));
        }

        static int ReverseNumber(string number)
        {
            var reversed = "";
            for (int i = number.Length - 1; i >= 0; i--)
                reversed += number[i];

            return int.Parse(reversed);
        }
    }
}
