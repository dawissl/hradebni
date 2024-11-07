namespace _05_CyklyCisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // knihovna pro generování náhodných čísel
            Random rnd = new Random();
            int cislo = rnd.Next(1, 11);
            while (cislo != 6)
            {
                Console.WriteLine($"- {cislo} -");
                cislo = rnd.Next(1, 11);
            }
            Console.WriteLine("---------------------");
            int druheCislo;
            do
            {
                druheCislo = rnd.Next(1, 11);
                if( druheCislo != 6)
                {
                    Console.WriteLine($"- {druheCislo} -");
                }
            } while( druheCislo != 6);
            Console.WriteLine("05_CyklyCisla");
            Console.Write("Zadejte cislo: ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            int greatherThanFive = 0;
            int sum = 0;
            while(num != 0)
            {
                count++;
                if (num > 5) greatherThanFive++;
                sum += num;
                Console.Write("Zadejte cislo: ");
               num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Uživatel vložil {count} čísel");
            Console.WriteLine($"Součet všech hodnot je {sum}");
            Console.WriteLine($"{greatherThanFive} čísel je větších než 5");
        }
    }
}