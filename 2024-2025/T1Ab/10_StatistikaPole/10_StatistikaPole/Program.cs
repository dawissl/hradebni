namespace _10_StatistikaPole
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            // Ukázka operace s polem
            // [ = AltGr + F
            // ] = AltGr + G
            int[] pole1 = new int[20]; // deklarace pole o velikosti 20
            pole1[5] = 200; // vložení hodnoty na 5 index / 6 pozici
            pole1[13] = 7;
            // deklarace pole s konkretními hodnotami
            int[] pole2 = { 2, 3, 4, 6, 8, 11, 20, -2 };
            // pole řetězců
            string[] slova = { "ahoj", "svete", "jak", "se", "mas", "?" };
            //základní operace s polem
            int prom = pole2[3]; // přiřazení hodnoty pole do proměnné
            int index = 6;
            pole2[index] = 200;
            pole2[1]++; // inkrement hodnoty v poli
            // implementace zadání
            Console.WriteLine("----- 10_StatistikaPole -----");
            Console.Write("Zadejte velikost pole: ");
            int velikost = int.Parse(Console.ReadLine());
            double[] hodnoty = new double[velikost];
            // vkládání hodnot do připraveného pole

            double suma = 0;
            for (int i = 0; i < velikost; i++) // alternativně i < hodnoty.Length
            {
                Console.Write($"Hodnota na indexu [{i}]: ");
                hodnoty[i] = int.Parse(Console.ReadLine());
                suma += hodnoty[i]; // v průběhu načítání hodnoty sčítáme
                
            }
            Console.WriteLine("Hodnoty načteny");
            // v cyklu projdeme hodnoty pro zjištění extrémů
            double max = hodnoty[0], min = hodnoty[0];
            for (int i = 1; i < velikost; i++)
            {
                if (hodnoty[i] > max)
                    max = hodnoty[i];
                if (hodnoty[i] < min)
                    min = hodnoty[i];
            }
            Console.WriteLine($"Maximum: {max}, Minimum: {min}, Průměr: {suma / velikost}, Součet: {suma}");
        }
    }
}