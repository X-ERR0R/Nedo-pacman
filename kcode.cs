using System;
using System.IO;

namespace progect
{
    internal class Program
    {
        static void EDIT_writeMassive(char[,] massive)
        {
            for (int i = 0; i < massive.GetLength(0); i++)
            {
                for (int j = 0; j < massive.GetLength(1); j++)
                {
                    Console.Write(massive[i, j]);
                }
                Console.WriteLine("");
            }
        }
        
        static char[,] EDIT_mapFile(string path, int maxRazmerStrocki)
        {
            string[] g = File.ReadAllLines(path);
            char[,] c = new char[g.Length, maxRazmerStrocki];
            for (int i = 0; i < g.Length; i++)
            {
                for (int j = 0; j < maxRazmerStrocki; j++)
                {
                    c[i, j] = g[i][j];
                }
            }
            return c;
        }
  
       
        static void Main(string[] args)
        {
            int score = 0;
            int x = 1, y = 1;
            Console.CursorVisible = false;
            char[,] map =EDIT_mapFile("map.txt",41);
            while (true) 
            {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Clear(); 
                EDIT_writeMassive(map);
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.SetCursorPosition(x,y);
                Console.Write('@');
                Console.SetCursorPosition(45,0);
                Console.ForegroundColor=ConsoleColor.White;
                Console.Write($"у вас {score} очков");
                ConsoleKeyInfo batton =Console.ReadKey();
                switch (batton.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (map[y, x - 1] == '#') { }
                        else if (map[y,x-1]== '*') 
                        {
                            x -= 1;
                            map[y, x] = ' ';
                            score++;
                        }
                        else
                        { x -= 1; }
                        break;

                    case ConsoleKey.RightArrow:
                        if (map[y, x + 1] == '#')
                        { }
                        else if (map[y, x + 1] == '*')
                        {
                            x += 1;
                            map[y, x] = ' ';
                            score++;
                        }
                        else
                        { x += 1; }
                        break;

                    case ConsoleKey.UpArrow:
                        if (map[y - 1, x] == '#') { }
                        else if (map[y-1, x] == '*')
                        {
                            y -= 1;
                            map[y, x] = ' ';
                            score++;
                        }
                        else
                        { y -= 1; }
                        break;

                    case ConsoleKey.DownArrow:
                        if (map[y + 1, x] == '#')
                        { }
                        else if (map[y + 1, x] == '*')
                        {
                            y += 1;
                            map[y, x] = ' ';
                            score++;
                        }
                        else
                        { y += 1; }
                        break;
                }

            }
        }
    }
}
