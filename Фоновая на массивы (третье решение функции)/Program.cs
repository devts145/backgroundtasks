using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая_на_массивы__Вариант_1_
{
    class Program
    {
        static int[] polotrnul(int[] posl)
        {
            int z = 0;
            int[] itog = new int[posl.Length];
            for (int i = 0; i < posl.Length; i++)
            {
                if (posl[i] > 0)
                {
                    itog[z] = posl[i];
                    z++;
                }
            }
            for (int i = 0; i < posl.Length; i++)
            {
                if (posl[i] < 0)
                {
                    itog[z] = posl[i];
                    z++;
                }
            }
            for (int i = 0; i < posl.Length; i++)
            {
                if (posl[i] == 0)
                {
                    itog[z] = posl[i];
                    z++;
                }
            }
            return itog;
        }
        static int[] zamenaelementov(int[] b, int min)
        {
            for (int i = 0; i < b.Length; i++)
            {
                if (i != 0 && i != b.Length - 1)
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
        static int naimenshi(int[] b)
        {
            int naim = b[0];
            for (int i = 1; i < b.Length; i++)
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
        static void vivodmas(int[] b)
        {
            for (int i = 0; i < b.Length; i++)
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
            vivodmas(b);
            Console.WriteLine(" ");
            Console.WriteLine("Наименьший элемент: {0}", naimenshi(b));
            int[] zamenmas = zamenaelementov(b, naimenshi(b));
            Console.WriteLine("Замененный массив: ");
            for (int a = 0; a < n; a++)
            {
                Console.Write("{0}\t", zamenmas[a]);
            }
            int[] polotrnol = polotrnul(posl);
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