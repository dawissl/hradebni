namespace TrojuhelnikPyramida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pyramida nebo trojúhelník?");
            string instruction = Console.ReadLine().ToUpper();
            if (instruction == "TROJÚHELNÍK" || instruction == "TROJUHELNIK")
            {
                Console.Write("Zadejte výšku: ");
                int height = int.Parse(Console.ReadLine());
                for (int i =0; i < height; i++)
                {
                    for(int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine("");
                }
            }
            else
            {
                if (instruction == "PYRAMIDA")
                {
                    Console.Write("Zadejte výšku: ");
                    int height = int.Parse(Console.ReadLine());
                    int line = height * 2 - 1;
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < line - height; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write("* ");
                        }
                        Console.WriteLine("");
                        line--;
                    }
                }
                else
                {
                    Console.WriteLine("Neznámá instrukce");
                }
            }
            
        }
    }
}