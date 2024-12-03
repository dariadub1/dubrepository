using System;

class Program
{
    static void Main()
    {
        int N = 5; 
        int[,] array = new int[,]
        {
            {  1,  2,  3,  4,  5 },
            { 16, 17, 18, 19,  6 },
            { 15, 24, 25, 20,  7 },
            { 14, 23, 22, 21,  8 },
            { 13, 12, 11, 10,  9 }
        };

        int centerX = N / 2;
        int centerY = N / 2;

        int[,] directions = { { 0, -1 }, { 1, 0 }, { 0, 1 }, { -1, 0 } };
        int dir = 0; 
        int steps = 1;
        int x = centerX, y = centerY; 

        Console.WriteLine("Элементы массива в спиральном порядке, начиная с центра:");

        Console.Write(array[x, y] + " "); 

        for (int i = 0; i < N * N - 1; i++) 
        {
            for (int j = 0; j < steps; j++)
            {
                x += directions[dir, 0];
                y += directions[dir, 1];

                if (x >= 0 && x < N && y >= 0 && y < N)
                {
                    Console.Write(array[x, y] + " ");
                }
            }

            dir = (dir + 1) % 4; 
            if (dir % 2 == 0) 
            {
                steps++;
            }
        }
    }
}
