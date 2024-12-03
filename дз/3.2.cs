internal class окружность
{
    static void Main()
    {
        int radius = 10;
        int diameter = radius * 2;

        for (int i = 0; i <= diameter; i++)
        {
            for (int j = 0; j <= diameter; j++)
            {
                double distance = Math.Sqrt(Math.Pow(i - radius, 2) + Math.Pow(j - radius, 2));

                if (distance > radius - 0.5 && distance < radius + 0.5)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

