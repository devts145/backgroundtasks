using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая__5._2__Вариант__1_
{
    class Parallelogram
    {
        protected double alfa;
        protected int h;
        protected int width;
        public Parallelogram()
        {
            alfa = 30;
            h = 4;
            width = 5;
        }
        public Parallelogram(double userAlfa, int userH, int userWidth)
        {
            this.alfa = userAlfa;
            this.h = userH;
            this.width = userWidth;
        }
        public virtual double alfaSv
        {
            get { return alfa; }
            set
            {   try
                {
                    if (value > 0f) alfa = value;
                    else throw new Exception("Value of angle alfa was negative. ");
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Error: {0} ", exc.Message);
                }
            }
        }
        public virtual int hSv
        {
            get { return h; }
            set
            {   try
                {
                    if (value > 0) h = value;
                    else throw new Exception("Value of height was negative. ");
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Error: {0} ", exc.Message);
                }
            }
        }
        public virtual int widthSv
        {
            get { return width; }
            set
            {   try
                {
                    if (value > 0) width= value;
                    else throw new Exception("Value of width was negative. ");
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Error: {0} ", exc.Message);
                }
            }
        }
        public virtual bool isSquare
        {
            get { if (alfa == 90 && Storona == width) return true; else return false; }
        }
        public virtual void Show()
        {
            Console.WriteLine("Width: {0}, height: {1}, angle alfa {2} of this parallelogram. ", width, h, alfa);
        }
        public int Area()
        {
            return (h * width);
        }
        public virtual double agleInRadians (double ualfa)
        {
            return (ualfa * Math.PI) / 180;
        }
        public double Storona
        {
            get { return (Area() / (Math.Round(Math.Sin(agleInRadians(alfa)))) / width); }
        }
        public virtual double Perimetr()
        {
            return (width + Storona) * 2; 
        }
        public virtual double Diagonal()
        {
            double firstdiag = Math.Pow(Storona, 2) + Math.Pow(width, 2) - 2 * Storona * width * Math.Cos(agleInRadians(alfa));
            double seconddiag = Math.Pow(Storona, 2) + Math.Pow(width, 2) - 2 * Storona * width * Math.Cos(agleInRadians(180 - alfa));
            if (firstdiag > seconddiag) return seconddiag;
            else return firstdiag;
        }
    }
    class Rectangle : Parallelogram
    {
        public Rectangle(int userH, int userWidth, double userAlfa)
            : base(userAlfa, userH, userWidth)
        {
            this.alfa = 90;
            this.h = userH;
            this.width = userWidth;
        }
        public Rectangle()
            : base()
        {
            this.h = 4;
            this.width = 3;
            this.alfa = 90;
        }
        public override double agleInRadians (double uAlfa)
        {
            return (uAlfa * Math.PI) / 180;
        }
        public override bool isSquare
        {
            get
            {
                if (h == width) return true;
                else return false;
            }
        }
        public override double Diagonal()
        {
            return Math.Sqrt(Math.Pow(h, 2) + Math.Pow(width, 2));
        }
        public override void Show()
        {
            Console.WriteLine("Width: {0}, height: {1}, angle alfa between: {2} of this rectangle. ", width, h, alfa);
        }
        public override double Perimetr()
        {
            return ((h + width) * 2);
        }
    }
    class Romb : Parallelogram
    {
        public Romb(double userAlfa, int userH, int userWidth)
            :base(userAlfa, userH, userWidth)
        {
            this.alfa = userAlfa;
            this.width = userWidth;
            this.h = userH;
        }
        public Romb()
            : base()
        {
            width = 4;
            h = 4;
        }
        public override double Perimetr()
        {
            return width * 4;
        }
        public override bool isSquare
        {
            get { if (alfa == 90) return true; else return false; }
        }
        public override double Diagonal()
        {
            double firstdiag = Math.Pow(width, 2) + Math.Pow(width, 2) - 2 * width * width * Math.Cos(agleInRadians(alfa));
            double seconddiag = Math.Pow(width, 2) + Math.Pow(width, 2) - 2 * width * width * Math.Cos(agleInRadians(180 - alfa));
            if (seconddiag > firstdiag) return seconddiag;
            else return firstdiag;
        }
        public override void Show()
        {
            Console.WriteLine("Width = {0}, height = {1} and angle {2} of romb. ", width, h, alfa);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Parallelogram[] pr = new Parallelogram[6];
                pr[0] = new Parallelogram();
                Console.WriteLine("Type angle alfa in parallelogram: ");
                double ua = double.Parse(Console.ReadLine());
                Console.WriteLine("Print height of parallelogram: ");
                int uh = int.Parse(Console.ReadLine());
                Console.WriteLine("Width: ");
                int uw = int.Parse(Console.ReadLine());
                if (ua < 0 ||uh < 0 || uw < 0) throw new Exception("Value of angle alfa or width or height in parallelogram was negative. ");
                pr[1] = new Parallelogram(ua, uh, uw);
                pr[2] = new Rectangle();
                Console.WriteLine("Write height of rectangle: ");
                uh = int.Parse(Console.ReadLine());
                Console.WriteLine("Width of rectangle: ");
                uw = int.Parse(Console.ReadLine());
                Console.WriteLine("Alfa of rectangle: ");
                ua = int.Parse(Console.ReadLine());
                if (ua < 0 || uh < 0 || uw < 0) throw new Exception("Value of angle alfa or width or height in rectangle was negative. ");
                pr[3] = new Rectangle(uh, uw, ua);
                pr[4] = new Romb();
                Console.WriteLine("Type alfa of romb: ");
                ua = double.Parse(Console.ReadLine());
                Console.WriteLine("Type height of romb: ");
                uh = int.Parse(Console.ReadLine());
                Console.WriteLine("Type width of romb: ");
                uw = int.Parse(Console.ReadLine());
                if (ua < 0 || uh < 0 || uw < 0) throw new Exception("Value of angle alfa or width or height in romb was negative. ");
                pr[5] = new Romb(ua, uh, uw);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine(@"-------------------------------");
                    Console.WriteLine("Output of {0} element of an array. ", i);
                    pr[i].Show();
                    if (pr[i].isSquare) Console.WriteLine("This is square."); else Console.WriteLine("This isn't square. ");
                    Console.WriteLine("Diagonal: {0:F2} ", pr[i].Diagonal());
                    Console.WriteLine("Perimetr: {0:f2} ", pr[i].Perimetr());
                    if (pr[i].GetType() == typeof(Parallelogram)) Console.WriteLine("Area: {0} ", pr[i].Area());
                    Console.WriteLine("Now I will demonstrate you working of the constructor (get). Height: {0}, width: {1}, angle alfa: {2}. ", pr[i].hSv, pr[i].widthSv, pr[i].alfaSv);
                    Console.WriteLine(@"-------------------------------");
                    Console.WriteLine(" ");
                }
                Console.WriteLine("First two elements are parallelograms with and without parameters, second two elements of an array are rectangles with and wothout parameters, third two elements are rombs with and without parameters.  ");
                Console.WriteLine(" ");
                Console.WriteLine("Now, type index (from 0 to 5 (inclusive)) of element in wich you want to change fields of class. If you don't want to change, enter a number out of range. ");
                int cases = int.Parse(Console.ReadLine());
                if (cases >= 0 && cases <= 5)
                {
                    Console.WriteLine("Firstly, we will change angle alfa of {0}. Enter new alfa angle in degrees: ", pr[cases].GetType());
                    double newAlfa = double.Parse(Console.ReadLine());
                    pr[cases].alfaSv = newAlfa;
                    Console.WriteLine("Now we can change height of {0}. Type new height: ", pr[cases].GetType());
                    int newH = int.Parse(Console.ReadLine());
                    pr[cases].hSv = newH;
                    Console.WriteLine("We will also change width of {0}. Type new width", pr[cases].GetType());
                    int newWidth = int.Parse(Console.ReadLine());
                    pr[cases].widthSv = newWidth;
                    Console.WriteLine("We have changed fields, lets see the result.");
                    Console.WriteLine(" ");
                    pr[cases].Show();
                    if (pr[cases].isSquare) Console.WriteLine("This is square."); else Console.WriteLine("This isn't square. ");
                    Console.WriteLine("Diagonal: {0:F2} ", pr[cases].Diagonal());
                    Console.WriteLine("Perimetr: {0:f2} ", pr[cases].Perimetr());
                    if (pr[cases].GetType() == typeof(Parallelogram)) Console.WriteLine("Area: {0} ", pr[cases].Area());
                    Console.WriteLine("Now I will demonstrate you working of the constructor (get). Height: {0}, width: {1}, angle alfa: {2}. ", pr[cases].hSv, pr[cases].widthSv, pr[cases].alfaSv);
                }
                else Console.WriteLine("Ok, goodbye, my friend! ");
            }
            catch (Exception exc)
            {
                Console.WriteLine("An error in Main(!): {0}. ", exc.Message);
            }
            Console.ReadKey();
        }
    }
}
