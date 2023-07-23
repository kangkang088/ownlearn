using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Demo5
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入语文成绩：");       
            //int chinese = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入数学成绩：");
            //int math = Convert.ToInt32(Console.ReadLine());
            //bool b1 = chinese > 90 && math > 90;
            //Console.WriteLine(b1);
            //bool b2 = chinese > 90 || math > 90;
            //Console.WriteLine(b2);
            //Console.ReadKey();


            //判断闰年
            Console.WriteLine("请输入一个年份来判断是否是闰年：");
            string strYear = Console.ReadLine();
            int year = Convert.ToInt32(strYear);
            bool b1 = year % 400 == 0;
            bool b2 = year % 4 == 0 && year % 100 != 0;
            bool b3 = b1 || b2;
            if (b3)
            {
                Console.WriteLine(b3);
            }
            else
            {
                Console.WriteLine(b3);
            }
        }
    }
}
