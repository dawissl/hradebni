using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _081220
{
    class Program
    {
        static void Main(string[] args)
        {
            if(Console.ReadLine() == "enum")
            {
                Console.WriteLine("Pocet studentu:");
                int pocet = int.Parse(Console.ReadLine());
                int[] znamky = new int[pocet];
                for (int i = 0; i < pocet; i++)
                {
                    Console.Write("Znamka {0}. studenta:", i + 1);
                    znamky[i] = int.Parse(Console.ReadLine());
                }

                int prospel = 0, neprospel = 0;

                for (int i = 0; i < pocet; i++)
                {
                    switch ((Clasiffication)znamky[i])
                    {
                        case Clasiffication.VYBORNY:
                        case Clasiffication.CHVALITEBNY:
                        case Clasiffication.DOBRY:
                        case Clasiffication.DOSTATECNY:
                            prospel++;
                            break;
                        case Clasiffication.NEDOSTATECNY:
                            neprospel++;
                            break;
                    }
                }

                Console.WriteLine("Ve tride uspělo {0} žáků, {1}% neuspělo",
                    prospel, neprospel / (double)pocet);
            }
            else
            {
                Console.WriteLine("Structura jednoducheho čtverce");
                Console.WriteLine("Zadejte stranu čtverce ve formatu: a,b");
                string input = Console.ReadLine();
                int[] strany = { int.Parse(input.Split(',')[0]), int.Parse(input.Split(',')[1]) };
                Ctverec rect = new Ctverec(strany[0], strany[1]);
                Console.WriteLine("Obsah ctverce: {0}.",rect.Obsah());
                Console.WriteLine("Obvod ctverce: {0}.",rect.Obvod());


            }
            

        }

        public enum Clasiffication
        {
            VYBORNY=1, CHVALITEBNY, DOBRY, DOSTATECNY, NEDOSTATECNY
        }

        public struct Ctverec
        {
            public Ctverec(int a, int b)
            {
                this.A = a;
                this.B = b;
            }

            public int A { get; set; }
            public int B { get; set; }

            public int Obsah()
            {
                return A * B;
            }

            public int Obvod()
            {
                return 2 * A + 2 * B;
            }







        }
    }
}
