using System;

namespace PozdraveniUzivatele
{
    class Program
    {
        static void Main(string[] args)
        {
            // deklarace proměnné datového typu string - řetězec
            string name;

            // pozdravení uživatele
            Console.WriteLine("Ahoj, jak se jmenuješ?");

            /* pomocí následujícího řádku do proměnné name uložíme hodnotu,
            která bude obsahovat jméno, které uživatel zadá */
            name = Console.ReadLine();

            // Pro vypsání oslovení můžeme použít několik způsobů, které jsou si podobné
            // vždy využijeme operátor + kterým lze řetězce spojovat do jednoho řetězce

            //zadefinování záčátku a konce věty a následné spojení 
            string start = "Moc mě těší ";
            string end = " já jsem Olaf a mám rád hezký kód.";
            Console.WriteLine(start + name + end);
            Console.WriteLine("-----------------------------------------------------");

            // řetězce můžeme spojit ještě před vložením jako argument
            string result = start + name + end;
            Console.WriteLine(result);
            Console.WriteLine("-----------------------------------------------------");

            //vše lze vyřešit bez deklarace proměnnýc a vložením řetězce přímo jako argument funkce
            Console.WriteLine("Moc mě těší " + name + " já jsem Olaf a mám rád hezký kód.");
            Console.WriteLine("-----------------------------------------------------\n");

            // pro úpravu řetězce se dají pužít i tzv. formátovací značky, které nám pomohou vkládat více řádků nebo tabulátory
            Console.WriteLine("Použítí\nnového\nřádku\npro\nkaždé\nslovo\n");
            Console.WriteLine("Vložení\t tabulátoru \tmezi \tkaždé \tslovo");

            // \n je netisknutelný znak, který přidá nový řádek
            // \t je netisknutelný znak, který vloží tabulátor


        }
    }
}
