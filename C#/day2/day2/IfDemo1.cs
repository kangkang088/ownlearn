using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class IfDemo1
    {
        static void Main(string[] args)
        {

            //1.
            Console.WriteLine("请输入你的年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age > 23) { Console.WriteLine("你该结婚了"); }
            else { Console.WriteLine("还不到结婚的年龄"); }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //2.
            Console.WriteLine("请输入老苏的语文成绩：");
            int chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入老苏的音乐成绩：");
            int music = Convert.ToInt32(Console.ReadLine());
            if ((chinese > 90 && music > 80) || (chinese == 100 && music > 70)) { Console.WriteLine("奖励100元"); }
            Console.WriteLine(); 
            Console.WriteLine(); 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //3.
            Console.WriteLine("请输入你的用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入你的密码");
            string idPassword = Console.ReadLine();
            bool b1 = userName == "admin";
            bool b2 = idPassword == "123456";
            if (b1 && b2) { Console.WriteLine("登录成功"); }
            else
            {
                Console.WriteLine("登录失败");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
