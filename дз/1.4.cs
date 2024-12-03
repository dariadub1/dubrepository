Console.Write("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int c = Convert.ToInt32(Console.ReadLine());

int result = 0;

for (int i = 0; i < 32; i++)
{
    int count = 0;

    if ((a & (1 << i)) != 0) count++;
    if ((b & (1 << i)) != 0) count++;
    if ((c & (1 << i)) != 0) count++;

    if (count >= 2)
    {
        result |= (1 << i);
    }
}

Console.WriteLine($"Новое число: {result} ");