using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()); // Вводим количество строк
            int[] q = new int[a];
            for (int w = 0; w < a; w++)
            {
                for (int d = 0; d <= w; d++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}