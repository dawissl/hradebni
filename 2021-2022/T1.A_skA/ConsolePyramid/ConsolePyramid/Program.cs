using System;

namespace ConsolePyramid
{
    class Program
    {
        static void Main(string[] args)
        {


            for(int i = 0; i < 5; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            for (int i = 1; i <= 5; i++)
            {
                for( int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }




            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }                    
                Console.WriteLine();
            }
            Console.WriteLine();

            int floor = 5;
            for(int i = floor; i > 0; i--)
            {
                for(int j =0;j<i;j++)
                    Console.Write("* ");
                Console.WriteLine();
            }


            //definice počtu mezer na řádek
            //délka řádku se rovná počtu mezer + počet hvězd
            int space = 6;
            for (int i = 0; i < 7; i++)
            {
                // mezery před první hvězdou
                // počet je menší o pořadí řádku
                for (int j = i; j < space; j++)
                {
                    Console.Write(" ");
                }
                //dokončení řádku s hvězdami
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                //ukončení příslušného řádku s hvězdami
                Console.WriteLine("");
            }
            
        }
    }
}
