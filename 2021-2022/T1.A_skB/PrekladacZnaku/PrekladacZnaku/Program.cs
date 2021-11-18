using System;

namespace PrekladacZnaku
{
    class Program
    {
        static void Main(string[] args)
        {
            // vuziti pomocné proměnné identifikující zda má aplikace stále pokračovat
            bool work = true;
            // dokud je proměnná true, aplikace bude stále běžet
            while (work)
            {
                //načtení instrukce od uživatele
                Console.WriteLine("Vložte číslo");
                int day = int.Parse(Console.ReadLine());

                //využití konstrukce switch-case pro rozhodnutí, co se má stát
                //dle vstupní hodnoty
                switch (day)
                {
                    case 1:
                        //volání funkce pro zobrazení nápovědy
                        ShowHelp();
                        break;
                    case 2:
                        Console.WriteLine("instrukce 2");
                        break;
                        //v případě zadání 666 je proměnná nastavena na false
                        //v další kontrole podmínky while cyklu nebude
                        //podmínka splněna a aplikace se ukončí
                    case 666:
                        Console.WriteLine("ukončení aplikace...");
                        work = false;
                        break;
                    default:
                        Console.WriteLine("Neznámá instrukce");
                        break;

                }
            }
        }

        //pomocná funkce, která nám zobrazí nápovědo
        private static void ShowHelp()
        {
            Console.WriteLine("nápověda pro praci s aplikaci");
        }
    }
}
