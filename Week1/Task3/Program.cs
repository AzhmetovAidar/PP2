using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()); // задаем массив 
            int[] q = new int[a];
            for (int d = 0; d < a; d++)
            {
                q[d] = Convert.ToInt32(Console.ReadLine()); // вбиваем числа
            }
            for (int d = 0; d < a; d++)
            {
                Console.Write(q[d] + " " + q[d] + " "); // и получаем копию каждого чила (одну)
            }
        }
    }
}