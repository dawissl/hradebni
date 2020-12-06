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
            } while (exit());
        }

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

            bool work = true;

            while (work)
            {
                Console.Write("Nacti operaci:");
                string operace = Console.ReadLine().ToLower();
                switch (operace)
                {
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
                operace = Console.ReadLine().ToUpper();

                switch (operace)
                {
                    case "JEDNA":
                        Console.WriteLine("Provádění operace JEDNA");
                        break;
                    case "DVA":
                        Console.WriteLine("Provádění operace DVA");
                        break;
                    case "EXIT":
                        Console.WriteLine("Ukončování aplikace");
                        break;
                    default:
                        Console.WriteLine("Neznámá operace");
                        break;
                }

            } while (operace != "EXIT");
        }
    }
}
