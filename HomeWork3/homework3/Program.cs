using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("每个数据换行输入");
            Shape shape1;
            shape1 = Factory.getShape(1);
            System.Console.Write("三角形面积为：");
            System.Console.WriteLine(shape1.getArea());
            Shape shape2;
            shape2 = Factory.getShape(2);
            System.Console.Write("圆形面积为：");
            System.Console.WriteLine(shape2.getArea());
            Shape shape3;
            shape3 = Factory.getShape(3);
            System.Console.Write("长方形面积为：");
            System.Console.WriteLine(shape3.getArea());
            Shape shape4;
            shape4 = Factory.getShape(4);
            System.Console.Write("正方形面积为：");
            System.Console.WriteLine(shape4.getArea());
        }
    }
}
