using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Task3
{
    public abstract class Figure
    {
        private string name;

        public Figure(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public abstract double Area2 { get; }
        public abstract double Area();
        public virtual void Print()
        {
            Console.WriteLine($"Фигура: {Name}");
        }
    }

    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(string name, double a, double b, double c) : base(name)
        {
            SetABC(a, b, c);
        }

        public void SetABC(double a, double b, double c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                Console.WriteLine("Некорректные значения сторон треугольника");
            }
        }

        public double GetA()
        {
            return a;
        }

        public double GetB()
        {
            return b;
        }

        public double GetC()
        {
            return c;
        }

        public override double Area2
        {
            get { return Area(); }
        }

        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стороны треугольника: {a}, {b}, {c}");
        }
    }

    public class TriangleColor : Triangle
    {
        private string color;

        public TriangleColor(string name, double a, double b, double c, string color) : base(name, a, b, c)
        {
            this.color = color;
        }

        public string Color
        {
            get { return color; }
        }

        public override double Area2
        {
            get { return base.Area2; }
        }

        public override double Area()
        {
            return base.Area();
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Цвет треугольника: {color}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TriangleColor triangle = new TriangleColor("Треугольник", 3, 4, 5, "Красный");
            triangle.Print();
            Console.WriteLine($"Площадь треугольника: {triangle.Area2}");
            Console.WriteLine();
            TriangleColor tr = new TriangleColor("Треугольник", 6, 8, 7, "Синий");
            tr.Print();
            Console.WriteLine($"Площадь треугольника: {tr.Area2}");
            Console.ReadLine();
        }
    }
}