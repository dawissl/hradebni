namespace _09_Tyden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("........... 09_Tyden .............");
            // nekonečná smyčka cyklu doku nenarazíme na instrukci, která ukončí aplikaci
            while (true)
            {
                Console.Write("Vyber instrukci [CZ|EN|KONEC]: ");
                // [ = altGr + F
                // ] = altGr + G

                string instrukce = Console.ReadLine().ToUpper();
                // příkaz break ukončí běh cyklu a pokračuje s kodem za cyklem
                if (instrukce == "KONEC") break;
                if (instrukce == "EN")
                {
                    Console.Write("Zadejte den v týdnu: ");
                    int den = int.Parse(Console.ReadLine());
                    switch (den)
                    {
                        case 1: // ověřujeme zda day == 1 
                            Console.WriteLine("Sunday");
                            break;
                        case 2:
                            Console.WriteLine("Monday");
                            break;
                        case 3:
                            Console.WriteLine("Tuesday");
                            break;
                        case 4:
                            Console.WriteLine("Wednesday");
                            break;
                        case 5:
                            Console.WriteLine("Thursday");
                            break;
                        case 6:
                            Console.WriteLine("Friday");
                            break;
                        case 7:
                            Console.WriteLine("Saturday");
                            break;
                        default:
                            Console.WriteLine("Uknown day");
                            break;
                    }
                }
                if (instrukce == "CZ")
                {
                    Console.Write("Zadejte den v týdnu: ");
                    int den = int.Parse(Console.ReadLine());
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
                            Console.WriteLine("Uknown day");
                            break;
                    }
                }
            }
        }
    }
}