using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte měsíc:");
            int mesic = int.Parse(Console.ReadLine());
            switch ((Months)mesic)
            {
                case Months.LEDEN:
                case Months.UNOR:
                case Months.PROSINEC:
                    Console.WriteLine("Zima");
                    break;
                case Months.BREZEN:
                    Console.WriteLine("Jaro");
                    break;
                case Months.CERVENEC:
                    Console.WriteLine("Leto");
                    break;
                case Months.ZARI:
                    Console.WriteLine("Podzim");
                    break;
                default:
                    Console.WriteLine("Neznámý měsíc");
                    break;
            }
            Console.WriteLine("----------------------------------");
            // prace se strukturou
            Obdelnik ob1 = new Obdelnik(10,6);
            Obdelnik ctverec = new Obdelnik(5);

            Console.WriteLine(ob1.Obsah());
            Console.WriteLine(ctverec.Obvod());
            Console.WriteLine(ob1);
            Console.WriteLine(ctverec);

        }
    }

    enum Months
    {
        LEDEN = 1, UNOR, BREZEN, DUBEN, KVETEN, CERVEN, CERVENEC, SRPEN, ZARI,
        RIJEN, LISTOPAD, PROSINEC
    };

    struct Obdelnik
    {
        public int A { get; set; }
        public int B { get; set; }

        public Obdelnik(int a, int b) {
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
                return $"Ctverec:[{A},{B}]";
            }
            else
            {
                // $ = alt + 36
                return $"Obelnik:[{A},{B}]";
            }
            
        }

    }
}
