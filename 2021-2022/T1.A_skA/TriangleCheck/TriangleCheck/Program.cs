using System;

namespace TriangleCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte tři délky stran:");
            
            // načtení délek stran z konzole
            int stranaA = int.Parse(Console.ReadLine());
            int stranaB = int.Parse(Console.ReadLine());
            int stranaC = int.Parse(Console.ReadLine());

            // kontrola podmínek pro trojúhelník
            if (stranaA + stranaB > stranaC)
            {
                // +++
                if (stranaC + stranaA > stranaB)
                {
                    // +++
                    if (stranaB + stranaC > stranaA)
                    {
                        // +++
                        Console.WriteLine("Trojúhelník lze sestrojit");
                    }
                }
            }

        }
    }
}
