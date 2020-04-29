using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая__3._4
{
    class Program
    { 
    
        static int indexstroki (int[][] MyArr)
        {
            int[] maxvstrokah = new int[MyArr.Length];
            int min = 0, max = -10001, index = 0;
            for (int i = 0; i < MyArr.Length; i++)
            {
                min = MyArr[i][0];
                for (int j = 0; j < MyArr[i].Length; j++)
                {
                    if (MyArr[i][j] > max)
                    {
                        max = MyArr[i][j];
                    }
                }
                maxvstrokah[i] = max;
            }
            min = maxvstrokah[0];
            for (int f = 0; f < maxvstrokah.Length; f++)
            {
                if (maxvstrokah[f] < min)
                {
                    min = maxvstrokah[f];
                    index = f;
                }
            }
            return index;
        }
        static void vivodsumm (int[] kolvopol)
        {
            for(int i = 0; i < kolvopol.Length; i++)
            {
                Console.Write("{0} \t", kolvopol[i]);
            }
        }
        static int[] kolvopolozhelem (int[][] MyArr)
        {
            int k = 0; ;
            int[] kolvopolozh = new int[MyArr.Length];
            for (int i = 0; i < MyArr.Length; i++)
            {
                for(int j = 0; j < MyArr[i].Length; j++)
                {
                    if ((MyArr[i][j]) > 0) k++;
                }
                kolvopolozh[i] = k;
                k = 0;
            }
            return kolvopolozh;
        }
        static void OutPutMass (int [][] MyArr)
        {
            for (int i = 0; i < MyArr.Length; i++)
            {
                foreach (int x in MyArr[i]) Console.Write("{0} ", x);
                Console.WriteLine();
            }
        }
        static int[][] InputArray (int kstrok)
        {
            string[] chislamassiva;
            int[][] MyArr = new int[kstrok][];
            for (int i = 0; i < kstrok; i++)
            {
                string user = Console.ReadLine();
                chislamassiva = user.Split(' ');
                MyArr[i] = new int[chislamassiva.Length];
                for (int j = 0; j < chislamassiva.Length; j++)
                {
                    MyArr[i][j] = int.Parse(chislamassiva[j]);
                }
            }
            return MyArr;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число строк ступенчатого массива: ");
            int numstrok = int.Parse(Console.ReadLine());
            int[][] MyArr = InputArray(numstrok);
            Console.WriteLine("Вывод массива: ");
            OutPutMass(MyArr);
            int[] kolvo = kolvopolozhelem(MyArr);
            Console.WriteLine("Количество положительных элементов в каждой строке ступенчатого массива: ");
            vivodsumm(kolvo);
            Console.WriteLine(" ");
            Console.WriteLine("Индекс строки массива, в которой расположено минимальное из найденных максимальных элементов: ");
            Console.WriteLine("{0} ", indexstroki(MyArr));
            Console.ReadLine();
        }
    }
}
