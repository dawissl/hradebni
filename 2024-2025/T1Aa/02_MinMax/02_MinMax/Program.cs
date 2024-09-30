namespace _02_MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* if (PODMINKA) //musime umet rozhodnout jestli je pravda/nepravda
             {
                 // kod ktery se vykona, pokud je podminka splnena
             }
             else
             {
                 // kod, ktery se vykona, pokud pomdminka neni splnena
                 // tento blok neni povinny - lze smazat vše s ELSE
             }*/

            /*    string heslo = "opice123";
                Console.Write("Zadej heslo: ");
                string pokusHeslo = Console.ReadLine();
                if (heslo == pokusHeslo)
                {
                    Console.WriteLine("Heslo je správné");
                }
                else
                {
                    Console.WriteLine("Heslo je špatné");
                }*/

            // Načtení čísla od uživatele
            Console.Write("Insert first number:");
            int a = int.Parse(Console.ReadLine());
            // deklarace dočasného min a max a nastaveni na první načtenou hodnotu
            int min = a;
            int max = a;
            // Načtení čísla od uživatele
            Console.Write("Insert second number:");
            int b = int.Parse(Console.ReadLine());
            // Načtení čísla od uživatele
            Console.Write("Insert third number:");
            int c = int.Parse(Console.ReadLine());
            if (b > max) max = b;
            if (c > max) max = c;
            if (b < min) min = b;
            if (c < min) min = c;
            Console.WriteLine($"The smallest number is {min} and the largest is  {max}");
        }
    }
}