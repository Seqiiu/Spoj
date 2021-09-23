using System;
using System.Collections.Generic;

namespace PP0506A
{
    public class Obj : IComparable<Obj>
    {
        public string Name { get; set; }
        public int OsX { get; set; }
        public int OsY { get; set; }
        public double Lenght { get; set; }
        public Obj(string name, int osX, int osY)
        {
            Name = name;
            OsX = osX;
            OsY = osY;
            Lenght = Math.Sqrt(osX * osX + osY * osY);
        }
        public int CompareTo(Obj other)
        {
            return Lenght.CompareTo(other.Lenght);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ilosc = int.Parse(Console.ReadLine());
            for (int i = 0; i < ilosc; i++)
            {
                var objs = new List<Obj>();
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                {
                    string[] kSub = Console.ReadLine().Split(' ');
                    objs.Add(new Obj(kSub[0], int.Parse(kSub[1]), int.Parse(kSub[2])));
                }
                objs.Sort();
                foreach (var item in objs)
                {
                    Console.WriteLine($"{item.Name} {item.OsX} {item.OsY}");
                }
                Console.ReadLine();
            }
        }
    }
}
