using System;
using System.ComponentModel.Design;
public class Game
{
    string[,] _field = new string[10, 10];

    int playerX = 0;
    int playerY = 0;

    public Game()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                _field[i, j] = "#"; 
            }
        }

        _field[4, 4] = "R"; 
        _field[7, 1] = "R"; 
        _field[3, 7] = "T";  
        _field[0, 8] = "T";  
        _field[8, 9] = "T";  
        _field[9, 2] = "T";  
        _field[2, 2] = "O";   
        _field[6, 8] = "O";   
        _field[9, 8] = "O"; 
        _field[0, 0] = "C"; 
        _field[1, 1] = "R";
        _field[4, 0] = "T"; 

    }
    public bool Swap(int i1, int j1, int i2, int j2)
    {
        // Проверка границ
        if (i1 < 0 || i2 < 0 || j1 < 0 || j2 < 0 || i1 > 9 || i2 > 9 || j1 > 9 || j2 > 9)
        {
            return false;
        }

        // Перемещение камня
        if (_field[i2, j2] == "R")
        {
            int stoneNewX = i2 + (i2 - i1);
            int stoneNewY = j2 + (j2 - j1);

            if (stoneNewX < 0 || stoneNewX > 9 || stoneNewY < 0 || stoneNewY > 9)
            {
                return false; 
            }

            if (_field[stoneNewX, stoneNewY] == "#")
            {
                _field[stoneNewX, stoneNewY] = "R";
                _field[i2, j2] = "#"; 
            }
            else if (_field[stoneNewX, stoneNewY] == "O")
            {
                _field[stoneNewX, stoneNewY] = "0"; 
                _field[i2, j2] = "#"; 
            }
            else
            {
                return false; 
            }
        }

        // Перемещение персонажа
        if (_field[i2, j2] == "#")
        {
            string temp = _field[i1, j1];
            _field[i1, j1] = "#";
            _field[i2, j2] = temp;

            if (temp == "C")
            {
                _field[i1, j1] = "#"; 
            }
            return true; 
        }
        else if (_field[i2, j2] == "O")
        {  
            string temp1 = _field[i1, j1];
            _field[i1, j1] = temp1;
            _field[i2, j2] = "0";

            if (temp1 == "C")
            {
                _field[i1, j1] = "#"; 
            }
            return true; 
        }
        return false; 
    }

    public void Print()
    {
        Console.Clear(); 
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                switch (_field[i, j])
                {
                    case "R": // Камень
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(_field[i, j] + " ");
                        break;
                    case "T": // Дерево
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(_field[i, j] + " ");
                        break;
                    case "O": // Неактивированная плита
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(_field[i, j] + " ");
                        break;
                    case "C": // Персонаж
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write(_field[i, j] + " ");
                        break;
                    case "#": // Трава
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(_field[i, j] + " ");
                        break;
                    default:
                        Console.ResetColor(); 
                        Console.Write(_field[i, j] + " ");
                        break;
                }
                Console.ResetColor(); 
            }
            Console.WriteLine();
        }
    }

    public void Run()
    {
        while (true)
        {
            Print();
            var key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (Swap(playerX, playerY, playerX, playerY - 1))
                        playerY--;
                    break;
                case ConsoleKey.RightArrow:
                    if (Swap(playerX, playerY, playerX, playerY + 1))
                        playerY++;
                    break;
                case ConsoleKey.UpArrow:
                    if (Swap(playerX, playerY, playerX - 1, playerY))
                        playerX--;
                    break;
                case ConsoleKey.DownArrow:
                    if (Swap(playerX, playerY, playerX + 1, playerY))
                        playerX++;
                    break;
            }
        }
    }
}
public static class Program
{
    public static void Main()
    {
        Game game = new Game();
        game.Run();
    }
}
