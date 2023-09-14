// See https://aka.ms/new-console-template for more information
using _01_Iteratror;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
double lastId = 0;

List<Zbozi> sklad = new List<Zbozi>();

Console.WriteLine("Kolik zboží budete vkládat?");
int count = int.Parse(Console.ReadLine());


for(int i = 0; i < count; i++)
{
    Console.Write("Název:");
    string tmpName = Console.ReadLine();
    Console.Write("Cena:");
    int tmpPrice = int.Parse(Console.ReadLine());
    sklad.Add(new Zbozi(tmpName, tmpPrice));
}
Console.WriteLine("-------------------------------");
Console.WriteLine("Vypis položek");

foreach(Zbozi z in sklad)
{
    Console.WriteLine(z);
}

double generateId() {
    
    return lastId++;

}
