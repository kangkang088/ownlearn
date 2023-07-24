using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class ForDemp3
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("请输入第{0}个人的成绩", i + 1);
                double score = 0;
                try
                {
                    score = Convert.ToDouble(Console.ReadLine());
                    if (score > 0 && score <= 100)
                    {
                        sum += score;

                    }
                    else
                    {
                        Console.WriteLine("输入错误，程序终止");
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入错误，程序终止");
                    break;
                }

            }
            Console.WriteLine("平均成绩为{0}", sum / 5);
            int total = 0;
            for (int i = 1; i <= 100; i++)
            {
                total = total + i;
                if (total >= 20)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            int num = 0;
            for (int i = 1; i <= 100; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {

                    if (i % j == 0)
                    {
                        Console.WriteLine("不是质数");
                        b = false;
                        break;
                    }
                    if (b)
                    {
                        num++;
                        Console.WriteLine("是质数，这个数是{0}", i);
                        break;
                    }

                }

            }

            Console.WriteLine("共有{0}个质数", num);
            int a1 = 15;
            int a2 = 156;
            int a3 = 14;
            int max = (a1 > a2 ? a1 : a2) > a3 ? a2 : a3;
            Console.WriteLine(max);
        }
    }
}
