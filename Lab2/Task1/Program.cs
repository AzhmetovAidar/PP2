using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
         static public bool QWERTY(string a)
        {
            bool b = true;
            for (int d=0;d<a.Length/2;d++)
            {
                if (a[d] != a[a.Length -1 -d])
                {
                    b = false;
                }
            }return b;
        }
        static void Main(string[] args)
        {
            FileStream st = new FileStream(@"C:\Users\Arsen Zhaxygaliyev\source\repos\1.txt", FileMode.Open, FileAccess.Read);
            StreamReader r = new StreamReader(st);
            string a = r.ReadLine();
            if (QWERTY(a))
            {
                Console.WriteLine("YES");
            }else
            {
                Console.WriteLine("NO");
            }
            st.Close();
            r.Close();
        }
    }
}
