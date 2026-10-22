Console.WriteLine("Zadej celé číslo");
// extrakce čísla z textu - může vzniknout chyba v programu
int x = int.Parse(Console.ReadLine());
//alternativní konverze ze string na int
//int y = Convert.ToInt32(Console.ReadLine());
// { = altGr + B
// } = altGr + N
if (x > 10)
{
    // rozšíření o další podmínku
    if (x > 100)
        Console.WriteLine("Mega velké číslo");
    else
        Console.WriteLine("Velké číslo");
}
else
{
    Console.WriteLine("Malé číslo");
}