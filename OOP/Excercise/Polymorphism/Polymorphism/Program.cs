using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);
            Circle c1 = new Circle(5);
            c.CallArea(r);
            c.CallArea(t);
            c.CallArea1(c1);
            Console.ReadKey();
        }
    }

    class Shape
    {
        protected int width, height;
        protected double radius;
        public Shape(int a = 0, int b = 0,double c = 0)
        {
            width = a;
            height = b;
            radius = c;
        }
        public virtual int area()
        {
            Console.WriteLine("Parent area :");
            return 0;
        }
        public virtual double area1()
        {
            Console.WriteLine("Parent area :");
            return 0;
        }

    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle area :");
            return (width * height);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int area()
        {
            Console.WriteLine("Triangle area :");
            return (width * height / 2);
        }
    }
    class Circle : Shape
    {
        public Circle(double c)
        {
            radius = c;
        }
        public override double area1()
        {
            Console.WriteLine("Circle area :");
            return 3.14*radius*radius;
        }
    }
    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a=sh.area();
           
            Console.WriteLine("Area: {0}", a);
          
            Console.WriteLine("");
        }

        public void CallArea1(Shape s)
        {
            double b = s.area1();
            Console.WriteLine("Area : {0}", b);

        }
    }
}



