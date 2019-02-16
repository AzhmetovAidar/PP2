using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static public bool Prime(int q) // фунция для проверки числа на (Prime)
        {
            if (q == 1)
                return false;
            else
                for (int d = 2; d < q; d++)
                {
                    if (q % d == 0)
                        return false;
                }
            return true;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());// просим ввести массив числа
            int[] q = new int[a];
            for (int d = 0; d < a; d++)
            {
                q[d] = Convert.ToInt32(Console.ReadLine());// сами числа
            }
            int cnt = 0;
            for (int d = 0; d < a; d++)
            {
                if (Prime(q[d]))//вызываем фунцию
                {
                    cnt++;


                }
            }
            Console.WriteLine(cnt); // amount of Prime numbers;
            for (int d = 0; d < a; d++)
            {
                if (Prime(q[d]))
                {
                    Console.Write(q[d] + " "); // сами числа;
                }
            }





        }
    }
}