Console.Write("a: ");
int a = Convert.ToInt32(Console.ReadLine);
Console.Write("b: ");
int b = Convert.ToInt32(Console.ReadLine);
Console.Write("c: ");
int c = Convert.ToInt32(Console.ReadLine);
if (a == 0)
{

    double x = -c / b;
    Console.WriteLine($"x: {x}");
}

else if (a != 0)
{
    int d = b * b - 4 * a * c;



    if (d > 0)
    {
        double k = (b * (-1) + Math.Sqrt(d)) / (2 * a);
        double t = (b * (-1) - Math.Sqrt(d)) / (2 * a);

        Console.WriteLine($"x1: {k} x2: {t} ");
    }



    else if (d == 0)
    {
        double y = b * (-1) / (2 * a);
        Console.WriteLine($"x1: {y}");
    }
    else if (d < 0)
    {
        Console.WriteLine("Нет корней");
    }
}
   