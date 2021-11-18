using System;

namespace PrekladacZnaku
{
    class Program
    {
        static void Main(string[] args)
        {
          // použiti proměnné pro kontrolo, zda má aplikace běžet
            bool work = true;
            //dokud je proměnná pravdivá probíhá cyklus
            while (work)
            {
                Console.Write("Vložte číslo:");
                //string znak = Console.ReadLine();
                int day = int.Parse(Console.ReadLine());

                switch (day)
                {
                    // v případě, že uživatel zadá hodnotu -1
                    // proměnná work je nastavena na false
                    // podmínka cyklu nebude splněná a aplikace
                    // se ukončí
                    case -1:
                        Console.WriteLine("ukončování aplikace");
                        work = false;
                        break;
                        //zadáním instrukce se volá funkce, kterou máme
                        //implementovanou - zobrazení nápovědy
                    case 1:
                        ZobrazNapovedu();
                        break;
                    case 2:
                        Console.WriteLine("úterý");
                        break;
                    case 3:
                        Console.WriteLine("středa");
                        break;
                    case 4:
                        Console.WriteLine("čtvrtek");
                        break;
                    case 5:
                        Console.WriteLine("pátek");
                        break;
                    case 6:
                        Console.WriteLine("sobota");
                        break;
                    case 7:
                        Console.WriteLine("neděle");
                        break;
                    default:
                        Console.WriteLine("neznámý den");
                        break;

                }
            }

        }

        //pomocná funkce pro zobrazení nápovědy
        private static void ZobrazNapovedu()
        {
            Console.WriteLine("nápověda aplikace");
        }
    }
}
