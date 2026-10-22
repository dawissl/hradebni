/**
 Vytvořte aplikaci, která vyžádá od uživatele zadat celé číslo.
 Na výstup uživateli vypíše, zda je zadané číslo kladné 
 nebo záporné. Nulu považujme chvilku za kladné.
Rozšíření: V případě, že přijde 0 ohlásí že hodnota je nulová.
 */
do
{
    Console.Write("Zadejte celé číslo: ");
    int cislo = int.Parse(Console.ReadLine());

    if (cislo >= 0)
    {
        if (cislo == 0)
        {
            Console.WriteLine($"Na vstupu je číslo 0");
        }
        else
        {
            Console.WriteLine($"{cislo} je kladné");
        }
    }
    else
    { // $ = alt + 36
        Console.WriteLine($"{cislo} je záporné");
    }


    if (cislo == 0)
    {
        Console.WriteLine($"Na vstupu je číslo 0");
    }
    else
    {
        if (cislo > 0)
        {
            Console.WriteLine($"{cislo} je kladné");
        }
        else
        {
            Console.WriteLine($"{cislo} je záporné");

        }
    }


    Console.WriteLine("Chcete pokračovat? ");

} while (Console.ReadLine().ToLower() == "ano");

