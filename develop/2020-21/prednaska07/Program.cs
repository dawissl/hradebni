using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prednaska07
{
    class Program
    {
        static void Main(string[] args)
        {
            
           
            Console.WriteLine("\"programovani\".Length");
            Console.WriteLine("programování".Length);
            Console.WriteLine("String.Compare(\"abc\" , \"abcde\");");
            Console.WriteLine(String.Compare("abc" , "abcde"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("String.Concat(\"abc\" , \"abcde\");");
            Console.WriteLine(String.Concat("abc", "abcde"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\"abcde\".Contains(\"abc\");");
            Console.WriteLine("abcde".Contains("abc"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\"aaaabbbb\".IndexOf(\"bb\");");
            Console.WriteLine("aaaabbbb".IndexOf("bb"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\"aaaabbbb\".LastIndexOf(\"a\");");
            Console.WriteLine("aaaabbbb".LastIndexOf("a"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\"a-b-c-d-e\".Split(\'-\');");
            Console.WriteLine("a-b-c-d-e".Split('-')[0]+", "+ "a-b-c-d-e".Split('-')[1] +
                ", " + "a-b-c-d-e".Split('-')[2] + ", " + "a-b-c-d-e".Split('-')[3] + 
                ", " + "a-b-c-d-e".Split('-')[4] );
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\"abcdadbca\".Replace(\"a\",\"X\");");
            Console.WriteLine("abcdadbca".Replace("a","X"));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\"abcdadbca\".ToUpper();");
            Console.WriteLine("abcdadbca".ToUpper());
            Console.WriteLine("--------------------------------------------\n");

            int[] pole = { 2, 5, 86, 1, 5, 3, 0 };

            Array.Sort(pole);
            for(int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }

            Console.WriteLine("\n--------------------------------------------\n");
            Array.Reverse(pole);
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            Console.WriteLine("\n--------------------------------------------\n");

            Console.WriteLine(pole.Max());
            Console.WriteLine(pole.Min());
            Console.WriteLine(pole.Sum());
            Console.WriteLine(pole.Average());

            Console.WriteLine("------------------------------------\n");

            Random rnd = new Random();


            Console.WriteLine(rnd.Next());
            Console.WriteLine(rnd.Next(1,10));
            Console.WriteLine(rnd.Next(50));
            
        }
    }
}
