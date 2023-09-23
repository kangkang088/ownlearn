using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18ref参数交换两个变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 30;
            Console.WriteLine("交换前：");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Swap(ref a, ref b);
            Console.WriteLine("交换后：");
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
        public static void Swap(ref int a,ref int b) 
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }
    }
}
