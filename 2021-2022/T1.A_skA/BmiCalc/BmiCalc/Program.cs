using System;

namespace BmiCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulačka BMI");
            // načtení váhy a výšky
            Console.Write("Zadejte výšku[m]:");
            double vyska = double.Parse(Console.ReadLine());
            Console.Write("Zadejte váhu[kg]:");
            double vaha= double.Parse(Console.ReadLine());
            // získání hodnoty BMI
            double vysledekBmi = BmiCalcul(vaha, vyska);
            // vypsání hodnoty na výstup
            Console.WriteLine($"Hodnotna BMI: {vysledekBmi}");
        }
        private static double BmiCalcul(double vaha,double vyska)
        {
            return vaha / (vyska * vyska);
        }
    }
}
