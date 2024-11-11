namespace _06_CyklyObrazce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int suma = 0;
            // for cyklus pro načtení 5 čísel
            for(int i = 0; i < 5; i++)
            {
                Console.Write($"Vlož {i + 1}. z 5:");
                int cislo = int.Parse( Console.ReadLine() );
                suma += cislo; // suma = suma + cislo
            }
            Console.WriteLine($"Součet načtených čísel je: {suma}");*/
            Console.Write("Zadejte šířku: ");
            int sirka = int.Parse(Console.ReadLine());
            Console.Write("Zadejte výšku: ");
            int vyska = int.Parse(Console.ReadLine());

            for(int i=0;i<vyska;i++)
            {
                for(int j = 0; j < sirka; j++)
                {
                    // TODO vypisuj +
                    Console.Write("+");
                }
                Console.WriteLine("");
            }

        }
    }
}