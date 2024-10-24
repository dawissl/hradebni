namespace _04_Vstupenky
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            Console.WriteLine("04_Vstupenky");
            Console.Write("Zadejte věk návštěvníka: ");
            int vek;
            vek = int.Parse(Console.ReadLine());
            if (vek >= 18)
            {
                Console.WriteLine("200 Kč");
            }
            else
            {
                if (vek <= 12)
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