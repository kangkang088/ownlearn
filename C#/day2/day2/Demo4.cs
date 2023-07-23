using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Demo4
    {
        static void Main(string[] args)
        {
            double a = 35;
            double b = 120;
            double sum = 3 * a + 2 * b;
            Console.WriteLine(sum);
            double sum_s = sum * 0.88;
            Console.WriteLine(sum_s);

            //两个类型相兼容
            //double 和 int


            int m = 10;
            double n = m;//自动类型转换 隐式类型转换

            double m1 = 10.56;
            int n1 = (int)m1;//强制类型转换，显式类型转换


            int a1 = 10;
            int b1 = 3;
            double c1 = (double)a1 / b1;//按小数输出
            Console.WriteLine("{0:0.00}",c1);//按两位小数输出

            //不兼容类型的类型转换用Convert


            //string转换为int\double

            string str1 = "123";
            double d1 = Convert.ToDouble(str1);
            Console.WriteLine(d1);
            string str2 = "456";
            int d2 = Convert.ToInt32(str2);
            Console.WriteLine(d2);

            Console.WriteLine("请输入你的汉语成绩：");
            string strChinese = Console.ReadLine();
            Console.WriteLine("请输入你的数学成绩：");
            string strMath = Console.ReadLine();
            Console.WriteLine("请输入你的英语成绩：");
            string strEnglish = Console.ReadLine();

            Console.WriteLine("请计算总成绩：");
            double chinese = Convert.ToDouble(strChinese);
            double english = Convert.ToDouble(strEnglish);
            double math = Convert.ToDouble(strMath);
            double sumGoal = chinese + english + math;
            double avg = sumGoal / 3;
            Console.WriteLine("总成绩是{0}，平均成绩是{1:0.00}",sumGoal,avg);
            Console.ReadKey();
        }
    }
}
