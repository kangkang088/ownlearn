using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class demo1
    {
        static void Main(string[] args)
        {
            //整数int
            //小数double 小数点后15-16位
            //字符char 需要用''
            //字符串string 需要用""
            //金钱类型decimal 加m/M；小数点后28-29位
            decimal money = 5000m;
            Console.WriteLine(money);
            int number = 0;
            Console.WriteLine(number);
            string name = "张三";
            Console.WriteLine("你好," + name);
            Console.ReadKey();
        }
    }
}
