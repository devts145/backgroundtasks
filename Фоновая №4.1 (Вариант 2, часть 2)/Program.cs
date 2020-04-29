using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая__4._1__Вариант_2__часть_2_
{
    class rectangle
    {
        double d;
        double sh;
        public rectangle()
        {
            d = 5.0;
            sh = 5.0;
        }
        public rectangle(double d, double sh)
        {
            this.d = d;
            this.sh = sh;
        }
        public double D
        {
            get { return d; }
            set
            {
                try
                {
                    if (value > 0.0) d = value;
                    else throw new Exception("вы ввели значение, которое меньше или равно нуля.Были оставлены значения по умолчанию. ");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
        public double Sh
        {
            get { return sh; }
            set
            {
                try
                {
                    if (value > 0.0) sh = value;
                    else throw new Exception("вы ввели значение, которое меньше или равно нуля. Были оставлены значения по умолчанию.");
                }
                catch (Exception exc) { Console.WriteLine(exc.Message); }
            }
        }
        public static rectangle Creation (double d, double sh)
        {
            rectangle obj;
            try
            {
                if (d % 5 == 0 && sh % 5 == 0)
                {
                    obj = new rectangle(d, sh);
                }
                else
                {
                    throw new Exception("Все значения не кратны 5, поэтому были заданы по умолчанию. ");
                }
            }
            catch (Exception exc)
            {
                obj = new rectangle();
                Console.WriteLine(exc.Message);
            }
            return obj;
        }
        public void outputsides()
        {
            Console.WriteLine(" \n Первая сторона: {0}. Вторая сторона: {1} \n ", d, sh);
        }
        public double diagonal
        {
            get { return (Math.Sqrt((Math.Pow(d, 2)) + (Math.Pow(sh, 2)))); }
        }
        public double radiusopokr
        {
            get { return ((Math.Sqrt((Math.Pow(d, 2)) + (Math.Pow(sh, 2)))) / 2); }
        }
        public double area
        {
            get { return d * sh; }
        }
        public double perimetr
        {
            get { return (d + sh) * 2; }
        }
        public bool square
        {
            get
            {
                if (d == sh) return true;
                else return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rectangle obj;
            Console.WriteLine("Введите 1, если хотите ввести значения для данной фигуры. ");
            try
            {
                byte cas = byte.Parse(Console.ReadLine());
                if (cas == 1)
                {
                    Console.WriteLine("Введите размеры фигуры, прямоугольник. Для начала длину прямоугольника: ");
                    double d = double.Parse(Console.ReadLine());
                    Console.WriteLine("Теперь введите ширину прямоугольника: ");
                    double sh = double.Parse(Console.ReadLine());
                    //obj = new rectangle(d, sh);
                    obj = rectangle.Creation(d, sh);
                }
                else obj = new rectangle();
            }
            catch (Exception erro)
            {
                Console.WriteLine("ОшЕбка: {0}. Были оставлены значения по умолчанию. ", erro.Message);
                obj = new rectangle();
            }
            Console.WriteLine("Хотите ли вы поменять значения? Введите 1, если хотите изменить: ");
            int caser = int.Parse(Console.ReadLine());
            if (caser == 1)
            {
                try
                {
                    Console.WriteLine("Введите другие значения. Длина: ");
                    double da = double.Parse(Console.ReadLine());
                    obj.D = da;
                    Console.WriteLine("Введите другие значения. Ширина: ");
                    double sha = double.Parse(Console.ReadLine());
                    obj.Sh = sha;
                }
                catch (Exception err)
                {
                    Console.WriteLine("ОшЕбка: {0}. Изменения данных не будет.", err.Message);
                } 
            }
            Console.WriteLine(" ");
            Console.WriteLine("Теперь выводим результат: ");
            obj.outputsides();
            Console.WriteLine(" ");
            Console.WriteLine("Площадь прямоугольника: {0}", obj.area);
            Console.WriteLine(" ");
            Console.WriteLine("Диагональ прямоугольника: {0:F2}", obj.diagonal);
            Console.WriteLine("Периметр прямоугольника: {0}", obj.perimetr);
            Console.WriteLine(" ");
            Console.WriteLine("Радиус описанной окружности: {0:F2}", obj.radiusopokr);
            Console.WriteLine("Является ли прямоугольник квадратом? {0}", obj.square);
            Console.ReadKey();
        }
    }
}
