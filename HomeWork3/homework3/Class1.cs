using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework3
{
    public abstract class Shape
    {
        public double area;
        public abstract double getArea();

    }
    public class Triangle : Shape
    {
        public Triangle(double sideLen1, double sideLen2, double sideLen3)
        {
            double p = (sideLen1 + sideLen2 + sideLen3) / 2;
            this.area = System.Math.Sqrt(p * (p - sideLen1) * (p - sideLen2) * (p - sideLen3));
        }
        public override double getArea()
        {
            return area;
        }
    }
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.area = System.Math.PI * radius * radius;
        }
        public override double getArea()
        {
            return area;
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(double sideLen1, double sideLen2)
        {
            this.area = sideLen1 * sideLen2;
        }

        public override double getArea()
        {
            return area;
        }
    }
    public class Square : Shape
    {
        public Square(double sideLen)
        {
            this.area = sideLen * sideLen;
        }
        public override double getArea()
        {
            return area;
        }
    }
    class Factory
    {
        public static Shape getShape(int shapeName)
        {

            Shape shape = null;
            if (shapeName == 1)
            {
                double sideLen1 = 0, sideLen2 = 0, sideLen3 = 0;
                System.Console.WriteLine("请输入三边长");
                sideLen1 = Convert.ToDouble(System.Console.ReadLine());
                sideLen2 = Convert.ToDouble(System.Console.ReadLine());
                sideLen3 = Convert.ToDouble(System.Console.ReadLine());
                shape = new Triangle(sideLen1, sideLen2, sideLen3);

            }
            else if (shapeName == 2)
            {
                double radius = 0;
                System.Console.WriteLine("请输入半径");
                radius = Convert.ToDouble(System.Console.ReadLine());
                shape = new Circle(radius);
            }
            else if (shapeName == 3)
            {
                double sideLen1 = 0, sideLen2 = 0;
                System.Console.WriteLine("请输入矩形的长和宽");
                sideLen1 = double.Parse(System.Console.ReadLine());
                sideLen2 = Convert.ToDouble(System.Console.ReadLine());
                shape = new Rectangle(sideLen1, sideLen2);

            }
            else if (shapeName == 4)
            {
                double sideLen = 0;
                System.Console.WriteLine("请输入正方形的边长");
                sideLen = double.Parse(System.Console.ReadLine());
                shape = new Square(sideLen);

            }
            return shape;
        }
    }
}

    
