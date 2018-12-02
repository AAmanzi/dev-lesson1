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

            //Task 3

            /*
            var number = Console.ReadLine();

            Console.WriteLine(ReverseNumber(number));
            */

            // Task 4

            
            var wordStart = Console.ReadLine();
            int choice;

            do
            {
                Console.WriteLine("1) Delete a letter of your choosing");
                Console.WriteLine("2) Add letters x times");
                Console.WriteLine("3) Change your chosen word with a new one");
                Console.WriteLine("4) Stop the program");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        var letter = char.Parse(Console.ReadLine());
                        wordStart = DeleteLetter(wordStart, letter);
                        Console.WriteLine(wordStart);
                        break;
                    case 2:
                        var numberOfLetters = int.Parse(Console.ReadLine());
                        wordStart = AddLetters(wordStart, numberOfLetters);
                        Console.WriteLine(wordStart);
                        break;
                    case 3:
                        wordStart = Console.ReadLine();
                        Console.WriteLine(wordStart);
                        break;
                    default:
                        break;
                }
                

            } while (choice != 4);
            

            


        }

        static int ReverseNumber(string number)
        {
            var reversed = "";
            for (int i = number.Length - 1; i >= 0; i--)
                reversed += number[i];

            return int.Parse(reversed);
        }

        static string DeleteLetter(string word, char letter)
        {
            var newWord = "";
           

            foreach (var character in word)
                if (character != letter)
                    newWord += character;

            return newWord;
        }

        static string AddLetters(string word, int numberOfLetters)
        {
            for (int i = 0; i < numberOfLetters; i++)
                word += char.Parse(Console.ReadLine());
            return word;
        }
    }
}
