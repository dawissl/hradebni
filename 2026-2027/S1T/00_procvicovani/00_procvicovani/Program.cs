Console.Write("Zadejte proměnnou x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Zadejte proměnnou y: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Zadejte proměnnou z: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine($"X: {x}, Y: {y}, Z: {z}");
int tmp;
if (x < z) {
    tmp = x;
    x = z;
    z = tmp;
}
if (x < y) {
    tmp = y;
    y = x;
    x = tmp;
}
if (y < z)
{
    tmp = z;
    z = y;
    y = tmp;
}

Console.WriteLine($"X: {x}, Y: {y}, Z: {z}");

