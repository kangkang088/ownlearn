using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class OutDemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string idPassword = Console.ReadLine();
            string message;
            bool b = YesOrNo(userName, idPassword, out message);
            Console.WriteLine("登录结果{0}",b);
            Console.WriteLine("登录信息{0}",message);
        }
        public static bool YesOrNo(string s1,string s2,out string message) 
        {
            if (s1 == "admin" && s2 == "123456") 
            {
                message = "登录成功";
                return true;
            }
            else if (s1 != "admin") 
            {
                message = "用户名错误";
                return false;
            }
            else
            {
                message = "密码错误";
                return false;
            }

        }
    }
}
