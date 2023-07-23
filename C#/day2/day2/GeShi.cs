using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class GeShi
    {
        static void Main(string[] args)
        {
            //收集用户信息，并以一定格式输出
            Console.WriteLine("请输入你的姓名：");
            string name = Console.ReadLine();
            if (name == "张三")
            {
                name = "法外狂徒张三";
            }
            else if (name == "李四")
            {
                name = "无情铁手李四";
            }
            Console.WriteLine("请输入你的故乡：");
            string country = Console.ReadLine();
            Console.WriteLine("请输入你的爱好：");
            string habits = Console.ReadLine();
            Console.WriteLine("请输入你的年龄：");
            string age = Console.ReadLine();
            
            //组织格式来输出
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            string infomation = "你的名字是：" + name + "," + "故乡是：" + country + "," + "爱好是：" + habits + "。";
            Console.WriteLine(infomation);
            Console.ReadKey();
        }
    }
}
