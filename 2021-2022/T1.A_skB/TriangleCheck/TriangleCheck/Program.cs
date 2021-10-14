using System;

namespace TriangleCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarace promenych
            int stranaA, stranaB, stranaC;

            //načtení hodnot od uživatele
            Console.WriteLine("Zadejte délky tří stran:");
            stranaA = int.Parse(Console.ReadLine());
            stranaB = int.Parse(Console.ReadLine());
            stranaC = int.Parse(Console.ReadLine());

            // kontrola podmínek pro sestrojení trojúhelníku
            if(stranaA + stranaB > stranaC)
            {
                // +++
                if(stranaA + stranaC > stranaB)
                {
                    // +++
                    if(stranaB + stranaC > stranaA)
                    {
                        //+++
                        Console.WriteLine("Trojúhelník lze sestrojit");
                    }
                    else
                    {
                        //---
                        Console.WriteLine("Trojúhelník nelze sestrojit #3");
                    }

                }
                else
                {
                    // ---
                    Console.WriteLine("Trojúhelník nelze sestrojit #2");
                }
            }
            else
            {
                // ---
                Console.WriteLine("Trojúhelník nelze sestrojit #1");
            }



        }
    }
}
