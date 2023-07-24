using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class WhileDemo1
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int sum1 = 0;
            while (n1 <= 100)
            {
                sum1 = sum1 + n1;
                n1++;
                Console.WriteLine("这是第{0}次打印。", n1 - 1);
                Console.WriteLine("总和是{0}", sum1);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //1.
            Console.WriteLine("请输入班级的人数");
            int number = Convert.ToInt32(Console.ReadLine());

            
            int n = 1;
            int sum = 0;
            while (n <= number)
            {
                Console.WriteLine("请输入第{0}个人的成绩", n);
                int goal = Convert.ToInt32(Console.ReadLine());
                sum += goal;
                n++;
            }
            Console.WriteLine("总成绩为{0}。", sum);
            Console.WriteLine("平均成绩为{0}。", sum / number);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //2.
            Console.WriteLine("这道题你会了吗？");
            string answer = Console.ReadLine();
            while (true)
            {
                if (answer == "会")
                {
                    Console.WriteLine("放学");
                    break;
                }
                Console.WriteLine("我再讲一遍，这道题你会了吗？");
                answer = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //3.
            double people = 80000;
            int year = 2006;
            while (people < 200000)
            {
                year++;
                people = people * 1.25;

            }
            Console.WriteLine("将在{0}年达到目标", year);
        }
    }
}

