using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1=Convert.ToDouble(Console.ReadLine());
            double x2=Convert.ToDouble(Console.ReadLine());
            double x3=Convert.ToDouble(Console.ReadLine());
            double v0 = Convert.ToDouble(Console.ReadLine());
            double t = Convert.ToDouble(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            double m = Convert.ToDouble(Console.ReadLine());
            double v = Convert.ToDouble(Console.ReadLine());
            double g = Convert.ToDouble(Console.ReadLine());
            double h = Convert.ToDouble(Console.ReadLine());
            double R1 = Convert.ToDouble(Console.ReadLine());
            double R2 = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double R = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double m1 = Convert.ToDouble(Console.ReadLine());
            double m2 = Convert.ToDouble(Console.ReadLine());
            double I = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A -"+Math.Sqrt(Math.Pow(x1,2)+Math.Pow(x2,2)));
            Console.WriteLine("Б -" + (x1 * x2 + x1 * x3 + x2 * x3));
            Console.WriteLine("В -" + (v0*t+(a*Math.Pow(t,2))/2));
            Console.WriteLine("Г -" + (m*Math.Pow(v,2)/2+m*g*h));
            Console.WriteLine("Д -" + (1/R1+1/R2));
            Console.WriteLine("Е -" + (m * g * Math.Cos(x)));
            Console.WriteLine("Ж -" + (2*Math.PI*R));
            Console.WriteLine("З -) " + (Math.Pow(b, 2) - 4 * a * c));
            Console.WriteLine("И -" + (y*(m1*m2)/Math.Pow(y,2)));
            Console.WriteLine("К -" + (Math.Pow(I,2)*R));
            Console.WriteLine("Л -" + (a*b)*(Math.Sin(c)));
            Console.WriteLine("М -" + (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(c)))); ;
            Console.WriteLine("Н -" + ((a*d+b*c)/(a*d)));
            Console.WriteLine("О -" + (Math.Sqrt(1-Math.Pow(Math.Sin(x),2))));
            Console.WriteLine("П -" + (1/Math.Sqrt(a*Math.Pow(x,2)+(b*x)+c)));
            Console.WriteLine("Р -" + ((Math.Sqrt(x+1)+Math.Sqrt(x-1)/Math.Pow(Math.Sqrt(x),2))));
            Console.WriteLine("С -" + (Math.Abs(x) + Math.Abs(x + 1)));
            Console.WriteLine("Т -" + (Math.Abs(1 - Math.Abs(x))));
            Console.ReadKey();
        }
    }
}
