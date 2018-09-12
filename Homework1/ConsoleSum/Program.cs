using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSum
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.WriteLine("请输入两个数字：");
            Console.Write("a=");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("a*b=" + a * b);


            
        }
    }
}
