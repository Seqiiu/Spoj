using System;

namespace FCTRL3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int liczba = int.Parse(Console.ReadLine());
                switch (liczba)
                {
                    case 0:
                    case 1: Console.WriteLine("0 1");break;
                    case 2:Console.WriteLine("0 2");break;
                    case 3:Console.WriteLine("0 6");break;
                    case 4:Console.WriteLine("2 4");break;
                    case 5:
                    case 6:
                    case 8:Console.WriteLine("2 0");break;
                    case 7:Console.WriteLine("4 0");break;
                    case 9:Console.WriteLine("8 0");break;
                    default:Console.WriteLine("0 0");break;
                }
            }
        }
    }
}
