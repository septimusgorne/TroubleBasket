using System;

namespace ExampleQueen
{
    class Queen
    {
        public int[,] board = new int[8, 8];
        
        public bool TryQueen(int i)
        {
            bool result = false;

            for (int j = 0; j < 8; j++)
            {
                if (board[i, j] == 0)
                {
                    SetQueen(i, j);
                    if (i == 7)
                        result = true;
                    else
                    {
                        if (!(result = TryQueen(i + 1)))
                            RemoveQueen(i, j);
                    }
                    if (result == true)
                        break;
                }
            }
            return result;
        }

        public void SetQueen(int i, int j)
        {
            for (int x = 0; x < 8; x++)
            {
                board[x, j]++;
                board[i, x]++;

                int fon;
                fon = j + i - x;
                if (fon >= 0 && fon < 8)
                    board[x, fon]++;
                fon = j - i + x;
                if (fon >= 0 && fon < 8)
                    board[x, fon]++;
            }
            board[i, j] = -1;
        }

        public void RemoveQueen(int i, int j)
        {
            for (int  x = 0;  x < 8;  x++)
            {
                board[x, j]--;
                board[i, x]--;

                int fon;
                fon = j + i - x;
                if(fon >= 0 && fon < 8)
                    board[x, fon]--;
                fon = j - i + x;
                if (fon >= 0 && fon < 8)
                    board[x, fon]--;
            }
            board[i, j] = 0;
        }
    }

    
    class Program
    {
        public static void Main(string[] args)
        {
            Queen queen = new Queen();

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    queen.board[i, j] = 0;
                }
            }

            queen.TryQueen(0);

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (queen.board[i, j] == -1)
                    {
                        Console.Write("*");
                    }
                    else
                        Console.Write(".");
                }
                Console.WriteLine();
            }
        }
    }
}