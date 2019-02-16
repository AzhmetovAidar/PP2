using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
         static public bool Prime(int a)
        {
            if (a == 1 || a == 0) return false;
                for (int d=2;d<=a/2;d++)
                {
                    if (a % d == 0)
                        return false;
                }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader r = new StreamReader(@"C:\Users\Arsen Zhaxygaliyev\source\repos\1.txt");
            StreamWriter w = new StreamWriter(@"C:\Users\Arsen Zhaxygaliyev\source\repos\2.txt");
            string a = r.ReadLine();
            string[] q = a.Split(' ');
            foreach (string s in q)
            {
                if (Prime(int.Parse(s)))
                {
                    w.Write(s + " ");
                    Console.WriteLine(s);
                }
            }
            r.Close();
            w.Close();
        }
    }
}
