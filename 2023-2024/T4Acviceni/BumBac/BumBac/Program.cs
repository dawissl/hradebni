// See https://aka.ms/new-console-template for more information
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("bumbác");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("bum");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("bác");
    }
    else
    {
        Console.WriteLine(i);
    }
}
