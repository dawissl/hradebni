using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Program pro zjištění obvodu trojúhelníku ze zadaných přímek");
            Console.WriteLine("----------------------------------------------------------------------");
            Console.Write("Zadejte stranu a:");
            a = int.Parse(Console.ReadLine());
            Console.Write("Zadejte stranu b:");
            b = int.Parse(Console.ReadLine());
            Console.Write("Zadejte stranu c:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Načtení stran dokončeno");

            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        int obvod = a + b + c;
                        Console.WriteLine("Obvod trojúhelníku je {0}", obvod);
                    }
                    else
                    {
                        Console.WriteLine("Trojúhelník nelze sestrojit");
                    }
                }
                else
                {
                    Console.WriteLine("Trojúhelník nelze sestrojit");
                }
            }
            else
            {
                Console.WriteLine("Trojúhelník nelze sestrojit");
            }


            bool check = TriangleCheck(a, b, c);
            if (check)
            {
                Console.WriteLine("Obvod trojúhelníku je {0}", a + b + c);

            }
            else
            {
                Console.WriteLine("Trojúhelník nelze sestrojit");
            }



          /*  if (a + b > c) //1
            {
                if (a + c > b) //2
                {
                    if (b + c > a) //3
                    {
                        int obvod = a + b + c;
                        Console.WriteLine("Obvod trojúhelníku je {0}", obvod);
                    }else //3
                    {
                        Console.WriteLine("Nelze");
                    }
                }else //2
                {
                    Console.WriteLine("Nelze");
                }
            }else //1
            {
                Console.WriteLine("Nelze");
            }*/









        }

        private static bool TriangleCheck(int a, int b, int c)
        {
            if (a + b < c) return false;
            if (a + c < b) return false;
            if (b + c < a) return false;
            return true;
        }
    }
}


