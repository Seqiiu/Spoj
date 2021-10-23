using System;

namespace PA05_POT
{

    class Program
    {
        static void Main(string[] args)
        {
            int ile = int.Parse(Console.ReadLine());
            for (int i = 0; i < ile; i++)
            {


                string[] k = Console.ReadLine().Split();
                if (k[0].Length >= k[1].Length)
                {
                    for (int j = 0; j < k[1].Length; j++)
                    {
                        Console.Write(k[0][j]);
                        Console.Write(k[1][j]);
                    }
                    Console.WriteLine();
                }
                else if (k[1].Length > k[0].Length)
                {
                    for (int j = 0; j < k[0].Length; j++)
                    {
                        Console.Write(k[0][j]);
                        Console.Write(k[1][j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
