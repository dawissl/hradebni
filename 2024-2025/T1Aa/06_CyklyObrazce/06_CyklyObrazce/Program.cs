namespace _06_CyklyObrazce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int suma = 0;
             for (int i = 0; i < 5; i++)
             {
                 // $ = altGr + 36
                 // { = altGr + B
                 // } = altGr + N
                 Console.Write($"Zadej {i + 1}. číslo z 5: ");
                 int cislo = int.Parse(Console.ReadLine());
                 suma += cislo; // suma = suma + cislo
             }
             Console.WriteLine($"Součet 5 čísel je: {suma}");*/
            Console.Write("Zadejte šířku: ");
            int sirka = int.Parse(Console.ReadLine());
            Console.Write("Zadejte výšku: ");
            int vyska = int.Parse(Console.ReadLine());
            for (int i = 0; i < vyska; i++)
            {

                for (int j = 0; j < sirka; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }


        }

    }
}