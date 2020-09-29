using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetngs
{
    class Program
    {
        static void Main(string[] args)
        {
            int vek;
            string jmeno;

            Console.WriteLine("Zadejte své jméno");

            jmeno = Console.ReadLine();

            Console.WriteLine("Ahoj " + jmeno + ", kolik je ti let?");

            vek = int.Parse(Console.ReadLine());

            Console.WriteLine("Páni, tobě už je " + vek + ", to teda čumím!");

            Console.WriteLine("Pání, tobě už je {0}, to teda čumím! Teď ještě vypíšu pětku: {1}", vek);




        }
    }
}
