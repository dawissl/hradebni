using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte číslo měsíce:");
            int mesic = int.Parse(Console.ReadLine());

            switch ((Mesice)mesic)
            {
                case Mesice.LEDEN:
                case Mesice.UNOR:
                case Mesice.PROSINEC:
                    Console.WriteLine("zima");
                    break;
                case Mesice.SRPEN:
                    Console.WriteLine("leto");
                    break;
                default:
                    Console.WriteLine("neexistující měsíc");
                    break;
            }

            Obdelnik ob1 = new Obdelnik(10, 7);
            Obdelnik ctverec = new Obdelnik(11);
            Obdelnik ob2 = new Obdelnik(5, 5);

            Console.WriteLine(ob1.A);
            ob1.A = 50;
            Console.WriteLine(ob1.A);

            Console.WriteLine(ob1.Obsah());

            Console.WriteLine(ob2);
            Console.WriteLine(ob1);

        }
    }

    enum Mesice
    {
        LEDEN=1, UNOR, BREZEN, DUBEN, KVETEN, CERVEN,
        CERVENEC, SRPEN, ZARI, RIJEN, LISTOPAD, PROSINEC
    };

    struct Obdelnik
    {
        public int A { get; set; }
        public int B { get; set; }

        public Obdelnik(int a, int b)
        {
            A = a;
            B = b;
        }

        public Obdelnik(int a)
        {
            A = a;
            B = a;
        }

        public int Obsah()
        {
            return A * B;
        }

        public int Obvod()
        {
            return 2 * A + 2 * B;
        }

        public override string ToString()
        {
            if (A == B)
            {
                return $"Ctverec: [{A},{B}]";
            }
            else
            {
                // $ - alt + 36
                return $"Obdelnik: [{A},{B}]";
            }
           
        }
    }
}
