using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
         static void QWERTY(FileSystemInfo fsi, int k )
        {
            string s = new string(' ', k);
            Console.WriteLine(s + fsi.Name);
            if (fsi.GetType() == typeof(DirectoryInfo))
            {
                FileSystemInfo[] arr = ((DirectoryInfo)fsi).GetFileSystemInfos();
                for (int d = 0; d<arr.Length;d++)
                {
                    QWERTY(arr[d], k + 3);
                }
            }
        }
        
            static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Arsen Zhaxygaliyev\source\repos\Lab2");
            QWERTY(dir, 0);
        }

    }
}
