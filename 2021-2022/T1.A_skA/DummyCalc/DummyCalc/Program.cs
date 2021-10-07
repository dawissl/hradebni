using System;

namespace DummyCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarovná proměnných a,b,c
            double a, b, c;
            // deklarace pole se třemi prvky
            double[] cisla = new double[3];

            // načíst hodnoty od uživatele a vložit do a,b,c
            Console.WriteLine("Zadejte tři čísla");
            cisla[0] = double.Parse(Console.ReadLine());
            cisla[1] = double.Parse(Console.ReadLine());
            cisla[2] = double.Parse(Console.ReadLine());

            // deklarace proměnných suma, součin, rozdíl
            // vložení výpočtu do proměnných

            double suma = cisla[0] + cisla[1] + cisla[2];
            double rozdil = cisla[0] - cisla[1] - cisla[2];
            double soucin = cisla[0] * cisla[1] * cisla[2];

            Console.WriteLine("Suma je: {0}", suma );
            Console.WriteLine("Rozdíl je: {0}", rozdil);
            Console.WriteLine("Součin je: {0}", soucin);

        }
    }
}
