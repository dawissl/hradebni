namespace _08_DokonaleCislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- 08_DokonaleCislo -----");
            Console.WriteLine("Zadejte vstupní číslo pro ověření");
            int cislo = int.Parse(Console.ReadLine());
            int suma = 1;
            for (int i = 2; i < cislo; i++)            
                if (cislo % i == 0) suma += i;
            // využití ternárního operátoru nahrazující if-else
            Console.WriteLine($"Zadané číslo {(suma == cislo ? "JE" : "NENÍ")} dokonalé");


        }
    }
}