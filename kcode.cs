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
        static void EDIT_writeMassive(char[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                    Console.Write(massive[i]);
                
            }
        }
        static void EDIT_writeMassive(int[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write(massive[i]);

            }
        }
        static void EDIT_writeMassive(int[,] massive)
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
            var g = File.ReadAllLines(path);
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
            char[,] map =EDIT_mapFile("map.txt",41);
            EDIT_writeMassive(map);
        }
    }
}
