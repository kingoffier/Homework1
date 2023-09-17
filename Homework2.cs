using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            (first, second) = (second, first);
            Console.WriteLine("Первое число = " + first);
            Console.WriteLine("Второе число = " + second);
            Console.ReadKey();

        }
    }
}
