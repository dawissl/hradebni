using System.Reflection.Metadata.Ecma335;

namespace _09_Tyden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string instrukce;
            // | = alt + 124
            // [ = altGr + F
            // ] = altGr + G
            do
            {
                Console.Write("Zvol instrukci [EN|CS|KONEC]: ");
                instrukce = Console.ReadLine().ToUpper();
                int den = 0;
                if (instrukce == "EN" || instrukce == "CS") // den si vyžádáme pouze pokud byl zvolen jazyk
                {
                    Console.Write("Zadej číslo dne v týdnu: ");
                    den = int.Parse(Console.ReadLine());
                }
                if (instrukce == "EN")
                {
                    // switch s anglickym tydnem
                    switch (den)
                    {
                        case 1:
                            Console.WriteLine("It is a Sunday");
                            break;
                        case 2:
                            Console.WriteLine("It is a Monday");
                            break;
                        case 3:
                            Console.WriteLine("It is a Tuesday");
                            break;
                        case 4:
                            Console.WriteLine("It is a Wednesday");
                            break;
                        case 5:
                            Console.WriteLine("It is a Thursday");
                            break;
                        case 6:
                            Console.WriteLine("It is a Friday");
                            break;
                        case 7:
                            Console.WriteLine("It is a Saturday");
                            break;
                        default:
                            Console.WriteLine("It is not a day");
                            break;
                    }
                }
                else if (instrukce == "CS")
                {
                    switch (den)
                    {
                        case 1:
                            Console.WriteLine("Pondělí");
                            break;
                        case 2:
                            Console.WriteLine("Úterý");
                            break;
                        case 3:
                            Console.WriteLine("Středa");
                            break;
                        case 4:
                            Console.WriteLine("Čtvrtek");
                            break;
                        case 5:
                            Console.WriteLine("Pátek");
                            break;
                        case 6:
                            Console.WriteLine("Sobota");
                            break;
                        case 7:
                            Console.WriteLine("Neděle");
                            break;
                        default:
                            Console.WriteLine("Neexistující den");
                            break;
                    }
                }
                else if (instrukce == "KONEC")
                {
                    // v případě, že přijde instrukce konec, přeskakujeme zbytek kódu
                    // a kontrolujeme podmínku cyklu
                    continue;
                }
                else
                {
                    Console.WriteLine("Neznámá operace");
                }
            } while (instrukce != "KONEC");

        }
    }
}