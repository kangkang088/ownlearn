using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class SwitchDemo1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请确定李四的评级：");
            string level = Console.ReadLine();
            switch (level)
            {
                case "A":
                    Console.WriteLine("涨工资500");
                    break;
                case "B":
                    Console.WriteLine("涨工资200");
                    break;
                case "C":
                    Console.WriteLine("涨工资150");
                    break;
                case "D":
                    Console.WriteLine("涨工资100");
                    break;
                default: Console.WriteLine("不涨工资");
                    break;
            }
        }
    }
}
