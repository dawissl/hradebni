using System.Security.Cryptography;

namespace _04_Vstupenky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte věk:");
            int vek = int.Parse(Console.ReadLine());
            if (vek <= 0)
            {
                Console.WriteLine("Neplatný věk");
            }
            else
            {
                if(vek >= 18)
                {
                    Console.WriteLine("200 Kč");
                }
                else
                {
                    if(vek < 12)
                    {
                        Console.WriteLine("100 Kč");
                    }
                    else
                    {
                        Console.WriteLine("150 Kč");
                    }
                }
            }
        }
    }
}