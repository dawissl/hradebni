namespace _02_MinMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string heslo = "opice123";
            Console.Write("Zadej heslo:");
            string pokusHeslo = Console.ReadLine();
            if(pokusHeslo == heslo) // == je porovnávací operátor
            {
                Console.WriteLine("Heslo zadáno správně");
            }
            else
            {
                Console.WriteLine("Špatné heslo");
            }

           if (PODMINKA) // podminka musí být rozhodnutelná pravda / nepravda
            {
                // pokud je podminka splnena
            }
            else
            {
                // pokud pominka neni splnena 
            }*/

            //načtení prvního čísla a uložení do proměnné a
            Console.Write("Insert first number:");
            int a = int.Parse(Console.ReadLine());
            //načtení prvního čísla a uložení do proměnné b
            Console.Write("Insert second number:");
            int b = int.Parse(Console.ReadLine());
            //načtení prvního čísla a uložení do proměnné c
            Console.Write("Insert third number:");
            int c = int.Parse(Console.ReadLine());
            int min = a;
            int max = a;
            // porovnání aktuální min hodnoty s případnou editací
            // pokud je podmínka splněna
            if (min > b) min = b;
            if(min > c) min = c;
            // porovnání aktuální max hodnoty s případnou editací
            // pokud je podmínka splněna
            if (max < b) max = b;
            if(max < c) max = c;
            //$ = AltGR + 36
            //{ = AltGr + B
            //} = AltGr + N
            Console.WriteLine($"The smallest number is {min} and the largest is {max}");
        }
    }
}