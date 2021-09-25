using System;

namespace TRN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] size = Console.ReadLine().Split(' ');
            int a = int.Parse(size[0]);
            int b = int.Parse(size[1]);
            int[,] wiersz = new int[a, b];
            for (int j = 0; j < a; j++)
            {
                string[] line = Console.ReadLine().Split(' ');
                for (int g = 0; g < b; g++)
                {
                    wiersz[j, g] = int.Parse(line[g]);
                }
            }
            for (int j = 0; j < b; j++)
            {
                for (int g = 0; g < a; g++)
                {
                    Console.Write(wiersz[g, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
