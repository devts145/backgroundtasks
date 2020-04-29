using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая__5__Вариант__1__сказали_немного_переделать_
{
    class Figura
    {
        private double x;
        private double y;
        public Figura()
        {
            x = 1.3;
            y = 2.7;
        }
        public Figura(double userX, double userY)
        {
            this.x = userX;
            this.y = userY;
        }
        public double xSv
        {
            get { return x; }
            set { x = value; }
        }
        public double ySv
        {
            get { return y; }
            set { y = value; }
        }
        public void Show()
        {
            Console.WriteLine("Point coordinates: ({0};{1}). ", x, y);
        }
    }
    class Triangle : Figura
    {
        private double a;
        private double b;
        int beta;
        public Triangle(double userA, double userB, int alfa, double userX, double userY)
            : base(userX, userY)
        {
            this.a = userA;
            this.b = userB;
            this.beta = alfa;
        }
        public Triangle()
            : base()
        {
            this.a = 4;
            this.b = 3;
            this.beta = 90;
        }
        public double aSv
        {
            get { return a; }
            set { a = value; }
        }
        public double bSv
        {
            get { return b; }
            set { b = value; }
        }
        public int betaSv
        {
            get { return beta; }
            set { beta = value; }
        }
        public double agleInRadians
        {
            get { return (beta * Math.PI) / 180; }
        }
        public double thirdSide
        {
            get { return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(agleInRadians)); }
        }
        public bool isRavnobedr
        {
            get
            {
                if ((thirdSide == a) || (thirdSide == b)) return true;
                else return false;
            }
        }
        public double Area
        {
            get
            {
                double c = thirdSide;
                double halfper = (a + b + c) / 2;
                return Math.Sqrt(halfper * (halfper - a) * (halfper - b) * (halfper - c));
            }
        }
        new public void Show()
        {
            base.Show();
            Console.WriteLine("Given sides, a = {0}, b = {1}, angle beta = {2}. ", a, b, beta);
        }
    }
    class Rectangle : Figura
    {
        double width;
        double height;
        public Rectangle()
            : base()
        {
            width = 4.5;
            height = 2.5;
        }
        public Rectangle(double userw, double userh, double userX, double userY)
            : base(userX, userY)
        {
            this.width = userw;
            this.height = userh;
        }
        public double widthSv
        {
            get { return width; }
            set { width = value; }
        }
        public double heightSv
        {
            get { return height; }
            set { height = value; }
        }
        public bool isQquare
        {
            get { if (height == width) return true; else return false; }
        }
        public double Area
        {
            get { return (height * width); }
        }
        new public void Show()
        {
            base.Show();
            Console.WriteLine("Two sides of rectangle. Width = {0} and height = {1}. ", width, height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle objTr1 = new Triangle();
            Rectangle objRect1 = new Rectangle();
            Console.WriteLine("Enter two sides of the triangle and the angle between them in degrees. Type the first side: ");
            double tr2a = double.Parse(Console.ReadLine());
            Console.WriteLine("Then type second side: ");
            double tr2b = double.Parse(Console.ReadLine());
            Console.WriteLine("And the angle between in degrees: ");
            int tr2beta = int.Parse(Console.ReadLine());
            Console.WriteLine("Now also type coordinates of point. Firstly, x: ");
            double userX = double.Parse(Console.ReadLine());
            Console.WriteLine("Y: ");
            double userY = double.Parse(Console.ReadLine());
            Figura fig = new Figura(userX, userY);
            Triangle objTr2 = new Triangle(tr2a, tr2b, tr2beta, userX, userY); 
            Console.WriteLine("Print height and width of rectangle. Width: ");
            double userWidth = double.Parse(Console.ReadLine());
            Console.WriteLine("Height: ");
            double userHeight = double.Parse(Console.ReadLine());
            Rectangle objRect2 = new Rectangle(userWidth, userHeight, userX, userY);
            Triangle[] triangles = new Triangle[2];
            triangles[0] = objTr1;
            triangles[1] = objTr2;
            Rectangle[] rectangles = new Rectangle[2];
            rectangles[0] = objRect1;
            rectangles[1] = objRect2;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(@"-----------------------------------------");
                triangles[i].Show();
                Console.WriteLine("Area of triangle: {0} ", triangles[i].Area);
                if (triangles[i].isRavnobedr == true) Console.WriteLine("This triangle is ravnobedrenniy. ");
                else Console.WriteLine("This triangle isn't ravnobedrenniy. ");
                Console.WriteLine("Third side of triangle: {0:F2}. ", triangles[i].thirdSide);
                Console.WriteLine(@"-----------------------------------------");
                rectangles[i].Show();
                Console.WriteLine("Area of rectangle: {0}. ", rectangles[i].Area);
                if (rectangles[i].isQquare == true) Console.WriteLine("This figure is a square. ");
                else Console.WriteLine("This figure isn't a square");
            }
            Console.WriteLine("Do you want to rewrite coordinates of point? Print 1, if you want. ");
            int cases = int.Parse(Console.ReadLine());
            if (cases == 1){
                Console.WriteLine("New x: ");
                fig.xSv = double.Parse(Console.ReadLine());
                Console.WriteLine("New y: ");
                fig.ySv = double.Parse(Console.ReadLine());
                fig.Show(); }
            Console.ReadKey();
        }
    }
}