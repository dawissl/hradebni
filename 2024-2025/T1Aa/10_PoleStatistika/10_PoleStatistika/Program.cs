namespace _10_PoleStatistika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ukázka operace s polem
            // [ = AltGr + F
            // ] = AltGr + G
            // deklarace pole o velikosti 20
            int[] mojePole = new int[20];
            // vložení hodnoty na 5 index / 6 pozici
            mojePole[5] = 200; 
            mojePole[1]++;
            // deklarace pole s konkretními hodnotami
            int[] mojeDruhePole = { 1, 2, 3, 4, 5, 88, 99, 105 };
            mojeDruhePole[2] += 10;
            // pole řetězců
            string[] slova = { "ahoj", "Svete", "jak" , "je", "?"};
            int index = 4;
            mojeDruhePole[index] *= 100;
            Console.WriteLine("..... 10_PoleStatistika .....");
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