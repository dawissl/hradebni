using System;

namespace ConsoleApp_Greetings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jak se jmenuješ?");
            string name = Console.ReadLine();

            string head = name.Substring(0, name.Length - 1).ToUpper();
            string tail = name.Substring(name.Length - 1,1).ToUpper();

            switch (tail)
            {
                case "A":
                case "E":
                    tail = "O";
                    break;
                case "B":
                case "D":
                case "F":
                case "L":
                case "N":
                case "P":
                case "R":
                case "S":
                case "T":
                case "V":
                case "W":
                    tail += "E";
                    break;
                case "C":
                case "Z":
                    tail += "I";
                    break;
                case "G":
                case "H":
                case "K":
                    tail += "U";
                    break;
                default:
                    break;
            }

            Console.WriteLine("\nAhoj " + head + tail + ", měj dnes krásný a radostný den!");
        }
    }
}
