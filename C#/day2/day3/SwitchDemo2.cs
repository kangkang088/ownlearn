using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class SwitchDemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入月份");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    if (month >= 1 && month <= 12)
                    {
                        switch (month)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                Console.WriteLine("31天");
                                break;
                            case 2:
                                if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
                                {
                                    Console.WriteLine("29天");
                                }
                                else
                                {
                                    Console.WriteLine("28天");
                                }
                                break;
                            default:
                                Console.WriteLine("30天");
                                break;

                        }
                    }
                    else { Console.WriteLine("输入的月份不符合要求，程序退出"); }
                }
                catch { Console.WriteLine("输入的月份不正确"); }
            }
            catch
            { 
                Console.WriteLine("输入的年份不正确");
            }
        }
    }
}
