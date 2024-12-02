using System.Security.Cryptography.X509Certificates;

namespace _09_Tyden
{

    internal class Program
    {
        static void Main(string[] args)
        {
            // proměnná instrukce rozhodujici o pokračování nebo ukončení aplikace / do-while cyklu

            string instrukce; 
            do
            {
                // | = alt + 124
                // [ = altGr + F
                // ] = altGr + G
                Console.Write("Zvol instrukci [EN|CS|EXIT]: ");
                instrukce = Console.ReadLine().ToUpper();
                if (instrukce == "EXIT") continue;
                Console.Write("Zadej číslo dne v týdnu: ");
                int den = int.Parse(Console.ReadLine());
                if (instrukce == "EN")
                {
                    // switch s nedělí jako první den
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
                else
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
            } while (instrukce != "EXIT");
        }
    }
}