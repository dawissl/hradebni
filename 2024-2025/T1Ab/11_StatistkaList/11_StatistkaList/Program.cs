namespace _11_StatistkaList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] poleCisel = new int[50];
             // vytvoření prázdného listu
             List<string> studenti = new List<string>();
             // přidávání položek pomocí funkce Add()
             studenti.Add("Kamil");
             studenti.Add("Eliška");
             studenti.Add("Jan");
             studenti.Add("Valerie");

             foreach (string jmeno in studenti)
             {
                 Console.WriteLine(jmeno);
             }

             // odebirání konkretní hodnoty nebo na pozici
             studenti.Remove("Jan");
             studenti.RemoveAt(2);
             Console.WriteLine("---------------------");
             foreach (string jmeno in studenti)
             {
                 Console.WriteLine(jmeno);
             }

             for (int i = 0; i < studenti.Count; i++)
             {
                 // [ = altGr + F
                 // ] = altGr + G
                 // $ = alt + 36
                 studenti[i] += $" {20 + i}";
             }
             Console.WriteLine("---------------------");
             foreach (string jmeno in studenti)
             {
                 Console.WriteLine(jmeno);
             }

             // funkce Contains zjištujici přítomnost prvku v kolekci
             if (studenti.Contains("Kamil"))
                 Console.WriteLine("Je přítomen");
             else
                 Console.WriteLine("Není přítomen");

             if(studenti.Contains("Eliška 21"))
                 Console.WriteLine("Je přítomna");
             else
                 Console.WriteLine("Není přítomna");*/

            Console.WriteLine("11_StatistikaList");
            Console.WriteLine("Dokud nevložíte hodnotu 0 budu vkládat čísla do kolekce");
            List<double> cisla = new List<double>();
            double tmp = double.Parse(Console.ReadLine());
            while(tmp != 0)
            {
                cisla.Add(tmp);
                tmp = double.Parse(Console.ReadLine());
            }
            // Veškerá čísla načtena
            // TODO MAX/MIN, AVG, SUM
            Console.WriteLine($"Maximum: {cisla.Max()}, Minimum: {cisla.Min()}, Průměr: {cisla.Average()}, Suma: {cisla.Sum()}");

        }
    }
}