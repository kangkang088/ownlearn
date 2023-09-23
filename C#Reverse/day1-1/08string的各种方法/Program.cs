using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08string的各种方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Console.WriteLine("请输入您心中想的人的名字：");
            string name = Console.ReadLine();
            //Length当前字符串的字符个数
            Console.WriteLine("这个名字的长度是{0}。",name.Length);

            Console.WriteLine("请输入您喜欢的课程：");
            string lesson1 = Console.ReadLine();
            string lesson2 = Console.ReadLine();
            //小写
            Console.WriteLine(lesson1.ToLower());
            //大写
            Console.WriteLine( lesson2.ToUpper());

            if (lesson1.Equals(lesson2, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("相同");
            }
            else {
                Console.WriteLine("不同");
            }
            
        }
    }
}
