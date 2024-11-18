namespace _07_Cykly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1) kolikrát budeme něco zadávat na vstup
            // 2) zadání daného počtu slov postupně
            // 3) pokud bude slovo delší než 4 znaky přičteme delku
            //      slova k sumě textu
            // 4) výslednou sumu budeme snižovat o 3 dokud nebude hodnota menší
            //  než 10
            // 5) vypíšeme zbytek sumy na výstup
              Console.Write("Kolik slov bude zadáno?");
              int pocetSlov = int.Parse(Console.ReadLine());
              int suma = 0;
              for (int i = 0; i < pocetSlov; i++)
              {
                  string vstup = Console.ReadLine();
                  if (vstup.Length > 4)
                  {
                      // suma = suma + vstup.Length;
                      suma += vstup.Length;
                  }
              }
              //while(!(suma < 10))
              while (suma >= 10)
              {
                  suma -= 3;
              }
              // $ = alt + 36
              Console.WriteLine($"Zbytek po operacích se slovy: {suma}");

            Console.WriteLine("-------------------------");
            Console.WriteLine("Nejvyšší hodnota z deseti načtených čísel");
            Console.WriteLine("Zadejte 10 čísel");
            int max = int.Parse(Console.ReadLine());
            for(int i = 1; i < 10; i++)
            {
                int tmp = int.Parse(Console.ReadLine());
                if (tmp > max) max = tmp;
            }
            Console.WriteLine($"Nejvyšší číslo je: {max}");




        }
    }
}