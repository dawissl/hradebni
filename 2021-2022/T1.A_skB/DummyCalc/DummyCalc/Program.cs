using System;

namespace DummyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarace proměnných a,b,c
            double a, b, c;
            // deklarace pole se třemi položkami
            double[] cisla = new double[3];
            Console.WriteLine("Zadejte tři celá čísla");
            /* 
             * načtení hodnot do proměnných a,b,c
             * funkce Console.ReadLine(); nám vráti řetězec a musíme 
             * hodnotu z řetězce vyparsovat pomocí funkce Parse
            */
            cisla[0] = double.Parse(Console.ReadLine());
            cisla[1] = double.Parse(Console.ReadLine());
            cisla[2] = double.Parse(Console.ReadLine());
          

            // deklarace proměnných suma, rozdíl, součin
            double suma = cisla[0] + cisla[1] + cisla[2];
            double rozdil = cisla[0] - cisla[1] - cisla[2];
            double soucin = cisla[0] * cisla[1] * cisla[2];

            // vypis výpočtů
            Console.WriteLine("Suma čísel je: {0}", suma);
            Console.WriteLine("Rozdíl čísel je: {0}", rozdil);
            Console.WriteLine("Součin čísel je: {0}", soucin);



        }
    }
}
