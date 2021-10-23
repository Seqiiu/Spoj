using System;

namespace Gra_Euklidesa
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string[] tab = Console.ReadLine().Split();
                int a = int.Parse(tab[0]);
                int b = int.Parse(tab[1]);
                int helper = 0;
                while (a!=b)
                {
                    helper = a;
                    a -= b;
                    if (a < 0)
                    {
                        b = -a;
                        a = helper;
                    }
                }
                Console.WriteLine(a + b);

            }
        }
    }
}
