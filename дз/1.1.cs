Boolean a;
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i < n; i++)
{
    a = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            a = false;
            break;
        }
    }
    if (a)
    {
        Console.WriteLine(i);
    }

}