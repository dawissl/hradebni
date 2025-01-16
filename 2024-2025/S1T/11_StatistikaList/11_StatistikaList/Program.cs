namespace _11_StatistikaList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* double[] pole = new double[10];
             List<string> osoby = new List<string>();

             // přídání položek do kolekce list
             osoby.Add("Kamil");
             osoby.Add("Eliška");
             osoby.Add("Jan");
             osoby.Add("Lucie");

             // výpis položek
             foreach (string p in osoby)
             {
                 Console.WriteLine(p);
             }

             // odstranění položek
             osoby.Remove("Kamil");
             osoby.RemoveAt(2);
             Console.WriteLine("-----------------");
             foreach (string p in osoby)
             {
                 Console.WriteLine(p);
             }
             // přístup k položkám v kolekci
             Console.WriteLine("-----------------");
             for (int i = 0; i < osoby.Count; i++)
             {
                 osoby[i] += $" {20 + i}";
                 Console.WriteLine(osoby[i]);
             }
             // využítí předdefinovaných funkcí
             if (osoby.Contains("Kamil"))
                 Console.WriteLine("Kamil je přítomen");
             else
                 Console.WriteLine("Kamil není přítomen");

             if (osoby.Contains("Eliška 20"))
                 Console.WriteLine("Eliška je přítomna");
             else
                 Console.WriteLine("Eliška není přítomna");
             */
            Console.WriteLine("11_StatistikaList");
            Console.WriteLine("Vkládej číselné hodnoty," +
                " ukončení zadávání nastane při vložení čísla 0");
            List<double> cisla = new List<double>();
            double num = double.Parse(Console.ReadLine());
            while(num != 0)
            {
                cisla.Add(num);
                num = double.Parse(Console.ReadLine());
            }
            if (cisla.Count > 0)
                Console.WriteLine($"Max: {cisla.Max()}, Min: {cisla.Min()}, Průměr: {cisla.Average()}, Součet: {cisla.Sum()}");
            else
                Console.WriteLine("Kolekce je prázdná");
        }
    }
}