using System;


class Game
{
    byte[] maze;
    byte wall = (byte)'|';

    public Game(int width, int height, bool startNow)
    {
        // Буфер окна
        Console.SetBufferSize(width, height);
        RecreateField();
        if (startNow)
            Start();
    }

    public Game(int width, int height)
        : this(width, height, false)
    {
        // TODO:
    }

    void InitMaze()
    {
        // Заполнение лабиринта
        for (int i = Console.BufferWidth / 2; i < maze.Length; ++i)
        {
            if (maze[i - 1] != wall && new Random(DateTime.Now.Millisecond).Next(0, 255) > 127)
                maze[i] = wall;
            System.Threading.Thread.Sleep(0);
        }
    }

    public void RecreateField()
    {
        // Лабирирнт
        maze = new byte[(Console.BufferWidth - 1) * (Console.BufferHeight - 1)];
        InitMaze();
    }

    public void Start()
    {
        int x = 0;
        int y = 0;

        int lastX;
        int lastY;
        // Вывод лабиринта
        Console.OpenStandardOutput().Write(maze, 0, maze.Length);

        Console.SetCursorPosition(0, 0);
        Console.Write('@');

        do
        {
            lastX = x;
            lastY = y;

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    y--;
                    break;
                case ConsoleKey.DownArrow:
                    y++;
                    break;
                case ConsoleKey.RightArrow:
                    x++;
                    break;
                case ConsoleKey.LeftArrow:
                    x--;
                    break;
                case ConsoleKey.Escape:
                    return;
            }

            if (x < 0)
                x = 0;
            else if (x >= Console.BufferWidth)
                x = Console.BufferWidth - 1;

            if (y < 0)
                y = 0;
            else if (y >= Console.BufferHeight)
                y = Console.BufferHeight - 1;

            if (x + Console.BufferWidth * y < maze.Length)
            {
                // Если текущая позиция == стене, тогда ...
                if (maze[x + Console.BufferWidth * y] == wall)
                {
                    // ... возвращаем исходные значения x и y,
                    // если они были изменены
                    if (lastX != x)
                        x = lastX;
                    if (lastY != y)
                        y = lastY;
                }
            }

            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.OpenStandardOutput().Write(maze, 0, maze.Length);
            Console.SetCursorPosition(x, y);
            Console.Write('@');

        } while (true);
    }
}

class Program
{
    public static void
    Main()
    {
        var game = new Game(30, 30);
        game.Start();
        game.RecreateField();
        game.Start();
    }
}