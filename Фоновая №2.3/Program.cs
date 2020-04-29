using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_2._3__Вариант_2_
{
    class Program
    {
        static int opredelenieizbit(int n)
        {
            n++;
            int summadel = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    summadel += i;
                }
            }
            return summadel;
        }
        static string izbornot(int summadel, int n)
        {
            string otv;
            if (summadel > n) otv = "является избыточным";
            else otv = "не является избыточным";
            return otv;
        }
        static int izbitchislo(int n)
        {
            int summadel = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    summadel += i;
                }
            }
            return summadel;
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            string itog = izbornot(izbitchislo(n), n);
            if (itog == "является избыточным") Console.Write("Число {0} {1} ", n, itog);
            else Console.Write("Число {0} {1}, ", n, itog);
            if (itog != "является избыточным")
            {
                n++;
                itog = izbornot(izbitchislo(n), n);
                if (itog == "является избыточным") Console.Write("новое число: {0}", n);
            }
            Console.ReadKey();
        }
    }
}