namespace _12_Funkce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vložení výsledku volání funkce do proměnné
            string text = MojePrvniFunkce();
            Console.WriteLine(text);
            Console.WriteLine("Vlož číslo pro ověření sudosti");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(JeSude(a));
        }
        /// <summary>
        /// Zjišťuje zda je zadané číslo sudé nebo liché
        /// </summary>
        /// <param name="cislo">číslo k ověření sudosti / lichosti</param>
        /// <returns>true pokud je sudé jinak false</returns>
        public static bool JeSude(int cislo)
        {
            if (cislo % 2 == 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Cvičná funkce pro demonstraci tvorby hlavičky funkce
        /// </summary>
        /// <returns> statický text ahoj!</returns>
        public static string MojePrvniFunkce()
        {
            return "Tak ahoj!";
        }

       

    }
}