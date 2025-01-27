namespace _12_Funkce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vložení výsledku volání funkce do proměnné
            string text = MojePrvniFunkce();
            Console.WriteLine(text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool JeSude(int a)
        {
            if (a % 2 == 0) 
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
            return "Ahoj!";
        }
    }
}