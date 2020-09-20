using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleValidate
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Program pro zjištění, zda lze ze zadaných přímek vytvořit trojúhelník");
            Console.WriteLine("----------------------------------------------------------------------");

            Console.Write("Zadejte stranu a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Strana a má  velikost {0}.", a);
            Console.Write("Zadejte stranu b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Strana a má  velikost {0}.", b);
            Console.Write("Zadejte stranu c:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Strana a má  velikost {0}.", c);
            Console.WriteLine("----------------------------------------------------------------------");
            
            if (a + b < c)
            {
                Console.WriteLine("Trojúhelník nelze sestrojit.");
            }
            else
            {
                if (a + c < b)
                {
                    Console.WriteLine("Trojúhelník nelze sestrojit.");
                }
                else
                {
                    if (b + c < a)
                    {
                        Console.WriteLine("Trojúhelník nelze sestrojit.");
                    }
                    else
                    {
                        Console.WriteLine("Trojúhelník lze sestrojit.");
                    }
                }
            }


            // řešení použitím nově vytvořené metody
            // string result = TriangleCheck(a, b, c);
            // Console.WriteLine(result);

          }

          /*private static string TriangleCheck(int a, int b, int c)
          {
              const string VALID = "Trojúhelník lze sestrojit.";
              const string INVALID = "Trojúhelník nelze sestrojit.";
              if (a + b < c) return INVALID;
              if (b + c < a) return INVALID;
              if (a + c < b) return INVALID;

            return VALID;
          }*/
    }
}

