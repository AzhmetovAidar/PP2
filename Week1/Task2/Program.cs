using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();  // Спрашиваем имя
            Console.WriteLine("What is your id?");
            string id = (Console.ReadLine()); // айди
            Console.WriteLine("How long have you been studing in KBTU?");
            string year = Console.ReadLine(); // год обучения
            Console.Write("Your name is ");
            Console.WriteLine(name);
            Console.Write("Your id is ");
            Console.WriteLine(id);
            Console.Write("You have been studing in KBTU for ");
            Console.Write(year);
            Console.WriteLine(" year");
        }
    }
}