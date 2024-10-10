namespace PodmineneProhozeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Statistika 4 čísel");
            Console.WriteLine("-------------------------------------------------------");
            Console.Write("Nacti prvni cislo: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nacti druhe cislo: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nacti treti cislo: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("Nacti ctvrte cislo: ");
            int d = int.Parse(Console.ReadLine());

            int suma = a + b + c + d;
            double prumer = suma / 4.0;
            int suda = 0, licha = 0;
            if (a % 2 == 0) suda++;
            else licha++;
            if (c % 2 == 0) suda++;
            else licha++;
            if (b % 2 == 0) suda++;
            else licha++;
            if (d % 2 == 0) suda++;
            else licha++;
            Console.WriteLine($"{Environment.NewLine}Statistika:");
            Console.WriteLine($"Suma čísel: {suma}{Environment.NewLine}Průměr čísel: {prumer}");
            if(licha == suda)
            {
                Console.WriteLine("Sudých a lichých čísel je stejne");
            }
            else
            {
                if(licha > suda)
                {
                    Console.WriteLine("Lichých čísel je vic");
                }
                else
                {
                    Console.WriteLine("Sudych čísel je vic");
                }

            }


        }
    }
}