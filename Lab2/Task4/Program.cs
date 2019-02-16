using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter rw = new StreamWriter(@"C:\Users\Arsen Zhaxygaliyev\source\repos\3.txt");
            rw.Write("Aidar");
            rw.Close();
            File.Copy(@"C:\Users\Arsen Zhaxygaliyev\source\repos\3.txt", @"C:\Users\Arsen Zhaxygaliyev\source\repos\4.txt");
            File.Delete(@"C:\Users\Arsen Zhaxygaliyev\source\repos\3.txt");
            
        }
    }
}
