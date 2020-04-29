using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_1
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Введите числа: ");
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("с = ");
            c = int.Parse(Console.ReadLine());
            double sum;
            sum = (Math.Pow(c + b, 1.0 / 3.0)) + Math.Sin(a / 4.0) + Math.Sqrt((a + b + 4) / 2.0) + Math.Pow(c, 2);
            Console.WriteLine(sum);
            Console.Read();
        }
    }
}