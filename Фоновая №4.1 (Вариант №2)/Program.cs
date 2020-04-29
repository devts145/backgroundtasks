using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая__4._1__Вариант__2_
{
    class rectangle
    {
        public double d;
        public double sh;
        public rectangle ()
        {
            d = 5.0;
            sh = 5.0;
        }
        public rectangle(double d, double sh)
        {
            this.d = d;
            this.sh = sh;
        }
        public void outputsides ()
        {
            Console.WriteLine(" \n Первая сторона: {0}. Вторая сторона: {1} \n ", d, sh);
        }
        public double diagonal()
        {
            return (Math.Sqrt((Math.Pow(d, 2)) + (Math.Pow(sh, 2))));
        }
        public double area ()
        {
            return (d * sh);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rectangle obj;
            Console.WriteLine("Введите 1, если хотите ввести значения для данной фигуры. ");
            byte cas = byte.Parse(Console.ReadLine());
            if (cas == 1)
            {
                Console.WriteLine("Введите размеры фигуры, прямоугольник. Для начала длину прямоугольника: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Теперь введите ширину прямоугольника: ");
                double sh = double.Parse(Console.ReadLine());
                obj = new rectangle(d, sh);
                /*obj.d = d;
                obj.sh = sh;*/
            }
            else obj = new rectangle();
            Console.WriteLine(" ");
            Console.WriteLine("Теперь выводим результат: ");
            obj.outputsides();
            Console.WriteLine(" ");
            Console.WriteLine("Площадь прямоугольника: ");
            Console.WriteLine(obj.area());
            Console.WriteLine(" ");
            Console.WriteLine("Диагональ прямоугольника: {0:F2}", obj.diagonal());
            //Console.WriteLine(obj.diagonal());
            Console.ReadKey();
        }
    }
}
