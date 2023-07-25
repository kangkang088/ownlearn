using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class RefDemo1
    {
        //ref 将一个变量带入一个方法中进行改变，并把改变后的值带出方法。
        //好处：省略返回值

        static void Main(string[] args)
        {
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine( salary);
            Console.ReadKey();
        }
        public static void JiangJin(ref double salary) 
        {
            salary += 500;
            
        }
        public static void FaKuan(ref double salary) 
        {
            salary -= 500;
        }
    }
}
