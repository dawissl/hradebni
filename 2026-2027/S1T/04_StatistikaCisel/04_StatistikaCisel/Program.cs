/*Console.Write("Zadejte 1. číslo: ");
int cislo1 = int.Parse(Console.ReadLine());
Console.Write("Zadejte 2. číslo: ");
int cislo2 = int.Parse(Console.ReadLine());
Console.Write("Zadejte 3. číslo: ");
int cislo3 = int.Parse(Console.ReadLine());
Console.Write("Zadejte 4. číslo: ");
int cislo4 = int.Parse(Console.ReadLine());
// suma čísel ze vstupu
int suma = cislo1 + cislo2 + cislo3 + cislo4;
Console.WriteLine($"suma čísel je {suma}");

// průměr hodnot
double prumer = suma / 4.0;
Console.WriteLine($"průměr čísel je {prumer}");

int liche = 0;
int sude = 0;

if(cislo1 % 2 == 0)
{
    sude++;
}
else
{
    liche++;
}

if (cislo2 % 2 == 0)
{
    sude++;
}
else
{
    liche++;
}

if (cislo3 % 2 == 0)
{
    sude++;
}
else
{
    liche++;
}

if (cislo4 % 2 == 0)
{
    sude++;
}
else
{
    liche++;
}
if (sude == liche) 
{
    Console.WriteLine($"Počet sudých a lichých čísel je stejný");
}
else
{
    Console.WriteLine($"Počet sudých je {sude}, počet lichých je {liche}");
}
*/

int pocet = 0;
int suma = 0;
int sude = 0;
int liche = 0;

Console.WriteLine("Zádávejte hodnoty, jakmile už nechcete zadejte číslo 0");

int x = int.Parse(Console.ReadLine());
while(x != 0)
{
    pocet++;
    suma = suma + x;
    if (x % 2 == 0)
    {
        sude++;
    }
    else
    {
        liche++;
    }
    x = int.Parse(Console.ReadLine());
}