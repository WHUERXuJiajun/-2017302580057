using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Max = 10;
            int[] a1 = new int[Max];
            int sum = 0;
            Console.WriteLine("请输入十个整数");
            for (int i = 0; i < Max; i++){
                string temp = Console.ReadLine();
                a1[i] = Int32.Parse(temp);
                sum += a1[i];
            }
            int average = sum / Max;
            int[] a2 = a1;
            int max = 0;
            for (int i = 0; i < Max - 1; i++){
                if (a2[i] > a2[i + 1]){
                    max = a2[i];
                }
                else{
                    max = a2[i + 1];
                }
            }
            Console.WriteLine("最大值:" + max);

            int[] a3 = a1;
            int min = 0;
            for (int i = 0; i < Max - 1; i++){
                if (a3[i] < a3[i + 1]) { 
                
                    min = a3[i];
                }
                else{
                
                    min = a3[i + 1];
                }
            }
            Console.WriteLine("最小值:" + min);
            Console.WriteLine("平均值:" + average);
            Console.WriteLine("和:" + sum);
        }
    }
}
