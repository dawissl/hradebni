using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1A_A_R
{
    class Program
    {

        static void Main(string[] args)
        {
            // demonstrace použití cyklů s nezmámým počtem opakování
            // vypisování načtených hodnot dokud není načtena 0

            int number;

            do
            {
                number = int.Parse(Console.ReadLine());
                Console.WriteLine("Nactene cislo: {0}", number);

            } while (number != 0);
            Console.WriteLine("Konec do-while cyklu");

            number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                Console.WriteLine("Nactene cislo: {0}", number);
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Konec while cyklu");

            // demonstrace vytváření funkcí a zanořování volání funkcí
            Console.WriteLine("Nacti cislo:");
            Console.WriteLine("Je cislo sude? {0}", Ano(JeSude(int.Parse(Console.ReadLine()))));

        }

        // definice a implementace funkcí v příkladu zanořování funkcí
        private static bool JeSude(int c)
        {
            return (c % 2) == 0;
        }

        private static string Ano(bool b)
        {
            if (b)
            {
                return "Ano";
            }
            else
            {
                return "Ne";
            }
        }

    }
}
