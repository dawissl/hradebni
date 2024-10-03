namespace _02_MinMax
{
    /// <summary>
    /// Aplikace, která vyzve uživatele k načtení 3 celých čísel.
    /// Z čísel vypíše nejvyšší a nejmenší hodnotu.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            /* if (PODMINKA)
             {
                 // VYKONA SE POKUD JE SPLNENO
             }
             else
             {
                 // VYKONA SE POKUD NENI SPLENO
             }*/
            Console.WriteLine("Nacti 3 cisla");
            Console.Write("Prvni cislo:");
            /**
             * Deklarace proměnné a jako int. 
             * Console.ReadLine() načte řetězcový vstup od uživatele
             * int.Parse() je funkce, která se pokusí řetězec převést
             * na datový typ int
             * Převedenou hodnotu vkládáme do proměnné a.
             */
            int a = int.Parse(Console.ReadLine());
            Console.Write("Druhe cislo:");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Treti cislo:");
            int c = int.Parse(Console.ReadLine());
            // deklarace aktualniho maxima a minima
            int max = a; // rovnou vlozim jednu z hodnot
            int min = a;
            // { = AltGr + B
            // } = AltGr + N
            if(max < b)
            {
                max = b;
            }
            if(max < c)
            {
                max = c;
            }
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            // $ = AltGr + 36
            Console.WriteLine($"Nejvyšší číslo je: {max} a nejmenší: {min}");
        }
    }
}