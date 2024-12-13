using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1; 
    static Random random = new Random();

    static void Main()
    {
        Console.WriteLine("Выберите режим:");
        Console.WriteLine("1. Игрок против Игрока");
        Console.WriteLine("2. Игрок против Компьютера");
        int mode = Convert.ToInt32(Console.ReadLine());

        int choice;
        bool validInput;

        do
        {
            Console.Clear();
            DrawBoard();

            if (mode == 1 || (mode == 2 && currentPlayer == 1))
            {
                Console.WriteLine($"Игрок {currentPlayer}, введите номер ячейки:");
                validInput = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 && board[choice - 1] != 'X' && board[choice - 1] != 'O';
            }
            else
            {
                choice = GetComputerMove();
                validInput = true;
                Console.WriteLine($"Компьютер поставил 'O' в ячейку {choice}.");
            }

            if (validInput)
            {
                board[choice - 1] = (currentPlayer == 1) ? 'X' : 'O';
                if (CheckForWin())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"Победил игрок {currentPlayer}!");
                    break;
                }

                if (CheckForDraw())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("Ничья!");
                    break;
                }

                currentPlayer = (currentPlayer == 1) ? 2 : 1;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Попробуйте снова.");
            }

        } while (true);
    }
    static void DrawBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }
    static bool CheckForWin()
    {
        return (board[0] == board[1] && board[1] == board[2] || 
                board[3] == board[4] && board[4] == board[5] ||
                board[6] == board[7] && board[7] == board[8] ||
                board[0] == board[3] && board[3] == board[6] || 
                board[1] == board[4] && board[4] == board[7] ||
                board[2] == board[5] && board[5] == board[8] ||
                board[0] == board[4] && board[4] == board[8] || 
                board[2] == board[4] && board[4] == board[6]);
    }
    static bool CheckForDraw()
    {
        foreach (char cell in board)
        {
            if (cell != 'X' && cell != 'O')
                return false;
        }
        return true;
    }

    static int GetComputerMove()
    {
        int choice;
        while (true)
        {
            choice = random.Next(1, 10); 
            if (board[choice - 1] != 'X' && board[choice - 1] != 'O')
            {
                break;
            }
        }
        return choice;
    }
}
