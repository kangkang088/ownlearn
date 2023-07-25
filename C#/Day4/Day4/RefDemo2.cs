using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class RefDemo2
    {
        static void Main(string[] args)
        {
            //使用方法交换两个int类型的变量，要求该方法不需要返回值

            //ref参数要求在方法外必须赋值，方法内可以不赋值
            int m = 10;
            int n = 20;
            Change(ref m, ref n);
            Console.WriteLine("交换后，m的值为{0}，n的值为{1}",m,n);
            Console.ReadKey();
        }
        public static void Change(ref int m, ref int n)
        { 
            int temp = m;
            m = n;
            n = temp;
        }
    }
}
