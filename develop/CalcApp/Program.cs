using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalcApp
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
            string opt;
            bool exit = false;
            do
            {
                Console.Write("Zvol operaci: ");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "E":
                    case "e":
                        exit = true;
                        break;
                    case "H":
                    case "h":
                        help();
                        break;
                    case "R":
                    case "r":
                        Console.Clear();
                        menu();
                        break;
                    case "+":
                        add();
                        break;
                    case "-":
                        minus();
                        break;
                    case "*":
                        mul();
                        break;
                    case "/":
                        div();
                        break;
                    default:
                        Console.WriteLine("Neznámá instrukce");
                        break;
                }

            } while (!exit);

        }

        private static void menu()
        {

            Console.WriteLine("Aplikace kalkulačka");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" [H]elp | [E]xit | [R]eset");
            Console.WriteLine("-------------------------------------------");
        }

        private static void help()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Nápověda pro aplikaci kalkulačka");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("H - zobrazení nápovědy\nE - ukončení aplikace\nR - restart aplikace");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Seznam matematických operací:");
            Console.WriteLine("+ - sčítání\n- - odčítání\n* - násobení\n/ - dělení");
            Console.WriteLine("-------------------------------------------");

        }

        private static void add()
        {
            Console.WriteLine("Sčítání");
            string a, b;
            a = GetNumberOnPosition(1);
            b = GetNumberOnPosition(2);

            Console.WriteLine("{0} + {1} = {2}", a, b, double.Parse(a) + double.Parse(b));
        }

        private static void minus()
        {
            Console.WriteLine("Odčítání");
            string a, b;
            a = GetNumberOnPosition(1);
            b = GetNumberOnPosition(2);
            Console.WriteLine("{0} - {1} = {2}", a, b, double.Parse(a) - double.Parse(b));
        }

        private static void mul()
        {
            Console.WriteLine("Násobení");
            string a, b;
            a = GetNumberOnPosition(1);
            b = GetNumberOnPosition(2);

            Console.WriteLine("{0} * {1} = {2}", a, b, double.Parse(a) * double.Parse(b));
        }


        private static void div()
        {
            Console.WriteLine("Dělení");
            string a, b;
            a = GetNumberOnPosition(1);
            b = GetNumberOnPosition(2);

            if (b.Equals("0"))
            {
                Console.WriteLine("Dělení 0 není povoleno!");
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", a, b, double.Parse(a) / double.Parse(b));
            }


        }

        private static bool isNumber(string num)
        {
            return double.TryParse(num, out _);
        }

        private static string GetNumberOnPosition(int v)
        {
            string number;
            int counter = 0;
            do
            {
                if (counter != 0)
                {
                    Console.WriteLine("Vložena nevalidní číselná hodnota");
                }
                Console.Write("Vlož {0}. číslo:", v);
                number = Console.ReadLine();
                counter++;
            } while (!isNumber(number));

            return number;
        }
    }
}
