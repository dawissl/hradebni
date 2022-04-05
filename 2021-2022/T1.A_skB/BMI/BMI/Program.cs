using System;

namespace BMI
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
            double vaha = double.Parse(Console.ReadLine());
            // získání hodnoty BMI
            double vysledekBmi = BmiCalcul(vaha, vyska);
            // vypsání hodnoty na výstup
            Console.WriteLine($"Hodnota BMI: {vysledekBmi}");
            // vypsani stavu
            string vysledek = VypsatStatus(vysledekBmi);
            Console.WriteLine($"Status: {vysledek}");
        }

        private static string VypsatStatus(double vysledekBmi)
        {
            if (vysledekBmi < 20) return Stav.PODVAHA.ToString();
            if (vysledekBmi >= 20 && vysledekBmi < 25) return Stav.NORMALNI_STAV.ToString();
            if (vysledekBmi >= 25 && vysledekBmi < 30) return Stav.MIRNA_OBEZITA.ToString();
            if (vysledekBmi >= 30 && vysledekBmi < 39) return Stav.STREDNI_OBEZITA.ToString();
            if (vysledekBmi >= 39) return Stav.TEZKA_OBEZITA.ToString();

            return "Neznámý stav";
        }

        private static double BmiCalcul(double vaha, double vyska)
        {
            if (vaha < 0) throw new Exception("Váha nesmí být záporná!");
            if(vyska <= 0) throw new Exception("Výška nesmí být menší rovna 0!");
            return vaha / (vyska * vyska);
        }

        enum Stav
        {
            PODVAHA, NORMALNI_STAV, MIRNA_OBEZITA,
            STREDNI_OBEZITA, TEZKA_OBEZITA
        };
    }
}
