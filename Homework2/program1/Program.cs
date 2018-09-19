using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数据(0---(2^31-1)) ：");
            int num;
            bool TF = int.TryParse(Console.ReadLine(), out num);
            if (TF){
                Console.WriteLine('\n');
                getPrimeList(num);
                Console.WriteLine('\n');
            }
            else{
                Console.WriteLine("请输入 0 到 （2^31-1）内的数字");
            }
        }
        static void getPrimeList(int num)
        {
            int  NPrime = 0;
            for (int i = 2; i <= (num / 2); i++){
                if (num % i == 0){
                    Console.Write(i + " ");
                    NPrime = num / i;
                    break;
                }
            }
            if (NPrime != 0){
                getPrimeList(NPrime);
            }
            else{
                Console.Write(num);
            }
        }
    }
}
