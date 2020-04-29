using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Точка по x = ");
            double xtoch = double.Parse(Console.ReadLine());
            Console.Write("Точка по y = ");
            double ytoch = double.Parse(Console.ReadLine());

            double U;

            if (((xtoch - 0) * (xtoch - 0) + (ytoch - 0) * (ytoch - 0)) < 1 * 1)
            {
                if (((xtoch - 0) * (xtoch - 0) + (ytoch - 0) * (ytoch - 0)) < 0.5 * 0.5)
                {
                    U = xtoch * ytoch + 7;
                    Console.WriteLine(U);
                }
                else
                {
                    U = xtoch - ytoch;
                    Console.WriteLine(U);
                }
            }
            else
            {
                U = xtoch * ytoch + 7;
                Console.WriteLine(U);
            }
            Console.Read();
        }
    }
}
