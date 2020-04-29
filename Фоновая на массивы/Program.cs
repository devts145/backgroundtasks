using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_на_массивы__Вариант_1_
{
    class Program
    {
        static int[] polotrnul(int[] posl, int n)
        {
            int negative = 0, positive = 0;
            for (int i = 0; i < n; i++)
            {
                if (posl[i] > 0)
                {
                    int g = posl[i];
                    posl[i] = posl[negative];
                    posl[negative++] = g;
                }
                if (posl[i] < 0)
                {
                    int g = posl[i];
                    posl[i] = posl[positive];
                    posl[positive++] = g;
                }
            }
            return posl;
        }
        static int[] zamenaelementov(int[] b, int n, int min)
        {
            for (int i = 0; i < n; i++)
            {
                if (i != 0 && i != n - 1)
                {
                    b[i] = b[i] + b[i + 1];
                }
                else
                {
                    b[i] = min;
                }
            }
            return b;
        }
        static int naimenshi(int[] b, int n)
        {
            int naim = b[0];
            for (int i = 1; i < n; i++)
            {
                if (b[i] < naim) naim = b[i];
            }
            return naim;
        }
        static int[] array(int n)
        {
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static void vivodmas(int[] b, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}\t", b[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Число элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());
            int[] b = array(n);
            int[] posl = new int[n];
            for (int h = 0; h < n; h++)
            {
                posl[h] = b[h];
            }
            Console.WriteLine(" ");
            vivodmas(b, n);
            int naim = naimenshi(b, n);
            Console.WriteLine(" ");
            Console.WriteLine("Наименьший элемент: {0}", naim);
            int[] zamenmas = zamenaelementov(b, n, naim);
            Console.WriteLine("Замененный массив: ");
            for (int a = 0; a < n; a++)
            {
                Console.Write("{0}\t", zamenmas[a]);
            }
            int[] polotrnol = polotrnul(posl, n);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Упорядоченный массив (сначала идут положительные элементы, затем отрицательные, затем нулевые: ");
            for (int f = 0; f < n; f++)
            {
                Console.Write("{0}\t", polotrnol[f]);
            }
            Console.ReadKey();
        }
    }
}