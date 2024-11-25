namespace _08_DokonaleCislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== 08_DokonaleCislo =====");
            Console.WriteLine("Zadejte vstupní číslo k ověření");
            int cislo = int.Parse(Console.ReadLine());
            int suma = 1;
            // využijeme znalosti, že dokonalá čísla jsou sudá
            // tedy dělitelé jsou menší nebo rovni polovině čísla
            for (int i = 2; i <= cislo / 2; i++)
                if (cislo % i == 0) suma += i;
            // využijeme ternarního operátoru nahrazující if-else
            Console.WriteLine($"Číslo {(suma == cislo ? "je" : "není")} dokonalé");

        }
    }
}