using System.Transactions;

namespace _11_StatistikaList
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            // [ = altGr + F
            // ] = altGR + F
            int[] pole = new int[10];
            List<string> studenti = new List<string>();
            // přidání položek do seznamu
            studenti.Add("Kamil");
            studenti.Add("Eliška");
            studenti.Add("Jan");
            studenti.Add("Valerie");
            foreach (string jmeno in studenti)
            {
                Console.WriteLine(jmeno);
            }
            //odstranění položky
            studenti.Remove("Jan");
            studenti.RemoveAt(2);
            Console.WriteLine("--------------------");
            foreach (string jmeno in studenti)
            {
                Console.WriteLine(jmeno);
            }
            for (int i = 0; i < studenti.Count; i++)
            {
                studenti[i] += $" {20 + i}";
            }
            Console.WriteLine("--------------------");
            foreach (string jmeno in studenti)
            {
                Console.WriteLine(jmeno);
            }
            if (studenti.Contains("Kamil"))
                Console.WriteLine("Je přítomen");
            else
                Console.WriteLine("Není přítomen");

            if (studenti.Contains("Eliška 21"))
                Console.WriteLine("Je přítomna");
            else
                Console.WriteLine("Není přítomna");
            */
            Console.WriteLine("11_StatistikaList");
            Console.WriteLine("Dokud nezadáte hodnotu 0," +
                " budou do seznamu přidávána čísla");
            List<double> cisla = new List<double>();
            double tmp = double.Parse(Console.ReadLine());
            while (tmp != 0)
            {
                cisla.Add(tmp);
                tmp = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Maximum: {cisla.Max()}, Minimum: {cisla.Min()}, Průměr: {cisla.Average()}, Suma: {cisla.Sum()}");


        }
    }
}