using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_задача__2__по_факту_3_
{
    class Program
    {
        static uint pripisivanie(ushort x1, ushort x2)
        {
            uint otv = x2;
            otv <<= 16;
            otv = otv | x1;
            return otv;
        }
        static void dvo(uint x2)
        {
            int k = 0;
            uint mask = Convert.ToUInt32(Math.Pow(2, 31));
            while (mask > 0)
            {
                k++;
                if ((x2 & mask) == 0) Console.Write("0");
                else Console.Write("1");
                if (k == 4)
                {
                    Console.Write(" ");
                    k = 0;
                }
                mask >>= 1;
            }
        }
        static int edinitsa(uint x1)
        {
            int k = 0;
            byte mask = 128;
            while (mask > 0)
            {
                if ((x1 & mask) != 0) k++;
                mask >>= 1;
            }
            return k;
        }
        static void Main(string[] args)
        {
            Console.Write("Какой номер? ");
            int num = int.Parse(Console.ReadLine());
            ushort x1, x2;
            switch (num)
            {
                case 1:
                    Console.Write("x1 = ");
                    x1 = ushort.Parse(Console.ReadLine());
                    Console.WriteLine("Целое число {0} имеет единичных битов: {1} ", x1, edinitsa(x1));
                    break;
                case 2:
                    Console.Write("x2 = ");
                    x2 = ushort.Parse(Console.ReadLine());
                    dvo(x2);
                    break;
                case 3:
                    Console.Write("x1 = ");
                    x1 = ushort.Parse(Console.ReadLine());
                    Console.Write("x2 = ");
                    x2 = ushort.Parse(Console.ReadLine());
                    uint otvet = pripisivanie(x1, x2);
                    Console.Write("{0}  ", otvet);
                    dvo(otvet);
                    break;
            }
            Console.ReadKey();
        }
    }
}