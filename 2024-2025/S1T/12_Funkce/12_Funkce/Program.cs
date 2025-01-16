namespace _12_Funkce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrvniFunkce());
            int cislo1 = 10;
            int cislo2 = 30;
            int soucet = SoucetCisel(cislo1, cislo2, 50);
            Console.WriteLine(soucet);
            Console.WriteLine(LzeSestrojitTrojuhelnik(6, 3, 7));
        }

        private static bool LzeSestrojitTrojuhelnik(int v1, int v2, int v3)
        {
            return v1 + v2 > v3 && v1 + v3 > v2 && v3 + v2 > v1;
        }

        public static string PrvniFunkce()
        {
            return "Ahoj";
        }

        public static int SoucetCisel(int a, int b, int c)
        {
            // a = cislo1, b = cislo2, c = 50
            int suma = a + b + c;
            return suma;
        }
    }
}