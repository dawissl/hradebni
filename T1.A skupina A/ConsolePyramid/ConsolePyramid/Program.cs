using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePyramid
{
    class Program
    {
        // vytvoření obrazové pyramidy
        static void Main(string[] args)
        {
              //definice počtu mezer na řádek
              //délka řádku se rovná počtu mezer + počet hvězd
              int space = 2;
              for (int i = 0; i < 3; i++)
              {
                  // mezery před první hvězdou
                  for (int j = 0; j < space; j++)
                  {
                     Console.Write("_");
                  }
                  //dokončení řádku s hvězdami
                  for (int j = 0; j <= i; j++)
                  {
                      Console.Write("*_");
                  }
                  //ukončení příslušného řádku s hvězdami
                  Console.WriteLine("");
                  // snižujeme počet mezer, na dalším řádku bude o jednu hvězdu více
                  space--;  
              }
         }         
    }
}

