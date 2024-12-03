double x = 0.9;

if (x < -1 || x > 1)
{
    Console.WriteLine("Ошибка");
}
else
{
    double sum = 1.0;
    double sl = 1.0; //слагаемое 

    int n = 1;

    while (sl >= 0.000001)
    {
        sl *= x / n;
        sum += sl;
        n++;
    }
    Console.WriteLine($"Приближение к e^{x} равно: {sum}");
}