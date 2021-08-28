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
            Menu();
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
                        Help();
                        break;
                    case "R":
                    case "r":
                        Console.Clear();
                        Menu();
                        break;
                    case "+":
                        Add();
                        break;
                    case "-":
                        Minus();
                        break;
                    case "*":
                        Mul();
                        break;
                    case "/":
                        Div();
                        break;
                    default:
                        Console.WriteLine("Neznámá instrukce");
                        break;
                }

            } while (!exit);

        }

        private static void Menu()
        {

            Console.WriteLine("Aplikace kalkulačka");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(" [H]elp | [E]xit | [R]eset");
            Console.WriteLine("-------------------------------------------");
        }

        private static void Help()
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

        private static void Add()
        {
            Console.WriteLine("Sčítání");
            string a, b;
            a = GetNumberOnPosition(1);
            b = GetNumberOnPosition(2);

            Console.WriteLine("{0} + {1} = {2}", a, b, double.Parse(a) + double.Parse(b));
        }

        private static void Minus()
        {
            Console.WriteLine("Odčítání");
            string a, b;
            a = GetNumberOnPosition(1);
            b = GetNumberOnPosition(2);
            Console.WriteLine("{0} - {1} = {2}", a, b, double.Parse(a) - double.Parse(b));
        }

        private static void Mul()
        {
            Console.WriteLine("Násobení");
            string a, b;
            a = GetNumberOnPosition(1);
            b = GetNumberOnPosition(2);

            Console.WriteLine("{0} * {1} = {2}", a, b, double.Parse(a) * double.Parse(b));
        }


        private static void Div()
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

        private static bool IsNumber(string num)
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
            } while (!IsNumber(number));

            return number;
        }
    }
}
