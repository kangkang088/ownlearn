using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Demo2
    {
        static void Main(string[] args)
        {
            string name = "卡卡西";
            string address = "火影村";
            int age = 30;
            string e_mail = "kakaxi@qq.com";
            decimal money = 2000m;
            //麻烦
            Console.WriteLine("我的名字是" + name + ",我住在" + address + ",我今年" + age + "岁了，我的邮箱是" + e_mail + "，我的工资是" + money);
            Console.ReadKey();
            //用占位符，先挖坑再填坑
            //多填没效果，少填出现 异常(语法无错误，运行过程中由于某些原因使程序无法继续正常进行)  语法错误(程序直接报错，无法运行)
            Console.WriteLine("我的名字是{0}，我住在{1}，我今年{2}岁了，我的邮箱是{3}，我的工资是{4}",name,address,age,e_mail,money);
            //交换两个值
            int a = 10;
            int b = 20;
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("交换后，a的值为{0}，b的值为{1}",a,b);
            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine("交换后，a的值为{0}，b的值为{1}", a, b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("交换后，a的值为{0}，b的值为{1}", a, b);
            Console.ReadKey();
        }
    }
}
