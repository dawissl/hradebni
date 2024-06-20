namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Objem nádoby:");
            double size = double.Parse(Console.ReadLine());
            Console.WriteLine("Do nádoby o objemu 100 l naleji 4x vodu pomocí zvolené nádoby");
            double value = 0;
            Console.WriteLine($"Naplněnost nádoby {value}/100 l");
            Console.WriteLine("První plnění");
            value += size;
            if (value > 100)
            {
                Console.WriteLine("Nádoba je plná");
            }
            else
            {
                Console.WriteLine($"Naplněnost nádoby {value}/100 l");
               
            }
            Console.WriteLine("Druhé plnění");
            value += size;
            if (value > 100)
            {
                Console.WriteLine("Nádoba je plná");
            }
            else
            {
                Console.WriteLine($"Naplněnost nádoby {value}/100 l");

            }
            Console.WriteLine("Třetí plnění");
            value += size;
            if (value > 100)
            {
                Console.WriteLine("Nádoba je plná");
            }
            else
            {
                Console.WriteLine($"Naplněnost nádoby {value}/100 l");

            }
            Console.WriteLine("Čtvrté plnění");
            value += size;
            if (value > 100)
            {
                Console.WriteLine("Nádoba je plná");
            }
            else
            {
                Console.WriteLine($"Naplněnost nádoby {value}/100 l");

            }
        }
    }
}