namespace _03_StatistikaCisel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /**
           * TODO LIST procvičování
           * 1) Načíst od uživatele číslo
           * 2) Vypsat uživateli informaci, jeli číslo kladné nebo záborné
           *    0 budeme považovat chvilku za kladnou hodnotu
           * 3) Aplikaci lze rozšířit o možnost, že dodáme informaci,
           *    že je číslo 0
           */
            // { = AltGr + B
            // } = AltGr + N
            // $ = Alt + 36
            Console.Write("Zadejte cislo: ");
            int number = int.Parse(Console.ReadLine());
            if (number >= 0)
            {
                if (number == 0)
                {
                    Console.WriteLine("nula");
                }
                else
                {
                    Console.WriteLine("kladné");
                }
            }
            else
            {
                Console.WriteLine("záporné");
            }
        }
    }
}