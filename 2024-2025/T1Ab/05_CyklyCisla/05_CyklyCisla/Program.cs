namespace _05_CyklyCisla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Knihovna umonujici generování náhodné hodnoty
            Random rnd = new Random();
            // generování čísla od 1 do 10 <1,11) zprava otevřený interval
            int cislo = rnd.Next(1, 11);
            //podmínka na začátku
            while (cislo != 4)
            {
                Console.WriteLine(cislo);
                cislo = rnd.Next(1, 11);
            }
            Console.WriteLine("----------------------");
            // podmínka na konci
            int number;
            do
            {
                number = rnd.Next(1, 11);
                if (number != 5) // zabránění výpisu čísla 5
                    Console.WriteLine(number);
            } while (number != 5);
            Console.WriteLine("####### 05_CyklyCisla ######");
            int vstup;
            int pocet = 0;
            int soucet = 0;
            int cislaVetsiNez5 = 0;
            vstup = int.Parse(Console.ReadLine());
            while (vstup != 0)
            {
                pocet++;
                soucet += vstup;
                if (vstup > 5) cislaVetsiNez5++;
                vstup = int.Parse((Console.ReadLine()));
            }
            Console.WriteLine($"Uživatel vložil {pocet} čísel");
            Console.WriteLine($"Součet čísel je {soucet}");
            Console.WriteLine($"Uživatel vložil {cislaVetsiNez5} čísel větších než 5");

        }
    }
}