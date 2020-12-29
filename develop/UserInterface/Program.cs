using System;

namespace UserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                throw new Exception("Invalid number of arguments");
            }
            else
            {
                // na základě vstupního argumentu se nám zobrazí příslušné řešení ovládání aplikace
                switch (args[0])
                {
                    case "example01":
                        Example01();
                        break;
                    case "example02":
                        Example02();
                        break;
                    case "example03":
                        Example03();
                        break;
                }
            }

        }

        

        /// <summary>
        /// Ovládání aplikace pomocí dodatečné funkce pro dotaz na ukončení
        /// </summary>
        private static void Example03()
        {

            do {
                Console.WriteLine("Provádění operací programu");
            } while (exit()); // o obsluhu se stará samostatná funkce, která rozhoduje zda bude program pokračovat
        }

        /// <summary>
        /// Funkce umožňuje uživateli rozhodnout, zda ukončí aplikace
        /// </summary>
        /// <returns> false pokud má dojít k ukončení</returns>
        private static bool exit()
        {
            Console.WriteLine("Ukončit program? (a/n)");
            return Console.ReadLine().ToLower() != "a";
        }

        /// <summary>
        /// Ovládání ukončení aplikace pomocí dodatečné proměnné, která řídí cyklus while
        /// </summary>
        private static void Example01()
        {
            // podmínka, která rozhoduje, za se bude cyklus opakovat
            bool work = true;

            while (work) // podmínka která je součástí cyklu může být pouze obsah proměnné
            {
                Console.Write("Nacti operaci:");
                string operace = Console.ReadLine().ToLower();

                switch (operace)
                {
                    // v momentě kdy je načteno slovo exit změní se hodnota proměnné, aby jsme mohli ukončit cyklus
                    case "exit":
                        work = false;
                        break;
                    default:
                        Console.WriteLine("Byla načtena operace {0}", operace);
                        Console.WriteLine("Zahajuji vykonávání...");
                        break;
                }
               
            }

            
        }

        /// <summary>
        /// použití proměnné pro řízení podmínky v cyklu do-while
        /// </summary>
        private static void Example02()
        {
            
            string operace;
            do
            {
                Console.Write("Nacti operaci: ");
                //nacteni operaci z konzole
                //pomoci řetězcové funkce ToUpper() změníme vše na velké písmo
                operace = Console.ReadLine().ToUpper();

                // dle zvolené operace se provádí konkrétní instrukce
                switch (operace)
                {
                    case "JEDNA":
                        Console.WriteLine("Provádění operace JEDNA");
                        break;
                    case "DVA":
                        Console.WriteLine("Provádění operace DVA");
                        break;
                        //instrukce exit
                    case "EXIT":
                        Console.WriteLine("Ukončování aplikace");
                        break;
                    default:
                        Console.WriteLine("Neznámá operace");
                        break;
                }
                // v momentě, kdy uživatel zadá EXIT je podmínka cyklu již není splněna a cyklus je tak ukončen
            } while (operace != "EXIT");
        }
    }
}
