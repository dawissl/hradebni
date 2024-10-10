namespace _03_StatistikaCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
             * TODO LIST procvičování
             * 1) Načíst od uživatele číslo
             * 2) Vypsat uživateli informaci, jeli číslo kladné nebo záborné
             * 0 budeme považovat chvilku za kladnou hodnotu
             * 3) Aplikaci lze rozšířit o možnost, že dodáme informaci, že je číslo 0
             */
            Console.Write("Vlož prosím číslo: ");
            // Pomoci Console.ReadLine() načteme řetezec.
            // Načtený řetězec je vstupním parametrem
            // funkce int.Parse(), která se pokusí z řetězce získat int hodnotu.
            // Výslednou hodnotu int vložíme do připravené proměnné cislo
            int cislo;
            cislo = int.Parse(Console.ReadLine());
            if(cislo >= 0)
            {
                if(cislo == 0)
                {
                    Console.WriteLine($"Nula");
                }
                else
                {
                    //$ = Alt + 36
                    //{ = Alt + B
                    //} = Alt + N
                    Console.WriteLine($"{cislo} je kladné");
                }
            }
            else
            {
                Console.WriteLine($"{cislo} je záporné");
            }
            Console.WriteLine("-------------------------------------------------------");

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

            // součet vsech promennych
            int suma = a + b + c + d;
            double prumer = suma / 4.0; // číslo je třeba uvest ve tvaru desetinneho čísla
            int suda = 0, licha = 0;
            if (a % 2 == 0) suda++; // inkrement
            else licha++;
            if (c % 2 == 0) suda++;
            else licha++;
            if (b % 2 == 0) suda++;
            else licha++;
            if (d % 2 == 0) suda++;
            else licha++;
            Console.WriteLine("Statistika:");
            Console.WriteLine($"Suma čísel: {suma}");
            Console.WriteLine($"Průměr čísel: {prumer}");
            if (licha == suda)
            {
                Console.WriteLine("Sudých a lichých čísel je stejne");
            }
            else
            {
                if (licha > suda)
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