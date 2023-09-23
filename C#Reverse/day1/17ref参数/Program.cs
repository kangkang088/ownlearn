using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17ref参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            double salary = 5000;
            JiangJin(ref salary);
            Console.WriteLine(salary);


        }
        //ref参数 将参数带出方法外，实现参数经过方法改变
        //ref参数要求必须在方法外部赋值，方法外部不需要赋值
        public static void JiangJin(ref double salary) { salary += 500; }
    }
}
