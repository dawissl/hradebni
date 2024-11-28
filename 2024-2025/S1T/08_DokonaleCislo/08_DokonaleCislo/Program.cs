namespace _08_DokonaleCislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---- 08_DokonaleCislo ----");
            Console.WriteLine("Zadejte číslo, zda je dokonalé");
            int cislo = int.Parse(Console.ReadLine());
            int suma = 1; // proměnná suma, kam budeme přičítat dělitele
            // využíváme toho, že každé číslo je dělitelné číslem 1
            for(int i=2; i<cislo; i++)
            {
                if(cislo % i == 0) // pokud je číslo dělitelem, přičteme jej
                {
                    suma += i;
                }
            }
            if (suma == cislo) // pokud je suma vstupní číslo, je číslo dokonalé
            {
                Console.WriteLine("Číslo je dokonalé");
            }
            else
            {
                Console.WriteLine("Číslo není dokonalé");
            }
        }
    }
}