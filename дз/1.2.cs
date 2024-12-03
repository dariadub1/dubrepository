int N = Convert.ToInt32(Console.ReadLine());
int K = Convert.ToInt32(Console.ReadLine());
int n = 0;
if (K == 0)
{
    Console.WriteLine("Ошибка: Деление на ноль недопустимо.");
    return;
}
if (N < 0)
{
    int sign = -1;

    N = Math.Abs(N);
    K = Math.Abs(K);
    while (N >= K)
    {
        N -= K;
        n++;
    }
    if (sign == -1)
    { n = -n; }
}
Console.WriteLine($"Целая часть {n}, остаток {N}");
