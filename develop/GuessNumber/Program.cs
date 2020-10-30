using System;
using System.Security.Cryptography;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(1, 10);
            Console.WriteLine("Uhádni číslo, které si myslím.");
            Console.WriteLine("Číslo je v rozmezí 1 až 10");
            while (!getNumber(number))
            {
                Console.WriteLine("Zkus to znovu");
            }

            Console.WriteLine("Gratuluji, myslel jsem si číslo {0}!", number);
                        
        }

        private static bool getNumber(int number)
        {
            Console.Write("Tip:");
            int guess = int.Parse(Console.ReadLine());
            if (guess == number) return true;

            if(guess > number)
            {
                Console.WriteLine("Číslo, které si myslím, je menší");
                return false;
            }
            else
            {
                Console.WriteLine("Číslo, které si myslím, je větší");
                return false;
            }

            
        }
    }
}
