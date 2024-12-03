Console.Write("1 сторона 1 треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("2 сторона 1 треугольника: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("3 сторона 1 треугольника: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("1 сторона 2 треугольника: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2 сторона 2 треугольника: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("3 сторона 2 треугольника: ");
int c1 = Convert.ToInt32(Console.ReadLine());

int k = a / a1;
int k1 = b / b1;
int k2 = c / c1;

if (k == k1)
{
    if (k1 == k2)
    {
        Console.WriteLine("Да");
    }
}
else
{
    Console.WriteLine("Нет");
}
