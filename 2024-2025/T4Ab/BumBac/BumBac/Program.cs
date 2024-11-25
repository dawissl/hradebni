namespace BumBac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplikace Bumbác");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Nahrazování čísel slovel dle dělitelnosti");
            for (int i = 1; i <= 1000000000; i++)
                Console.WriteLine(i % 15 == 0 ? "Bumbác" : i % 5 == 0 ? "Bác" : i % 3 == 0 ? "Bum" : i.ToString());

        }
    }
}