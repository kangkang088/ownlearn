using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class StringBuilderDemo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入一个人的名字");
            string name = Console.ReadLine();
            Console.WriteLine("{0}的长度是{1}",name,name.Length);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("请输入你喜欢的课程");
            string s1 = Console.ReadLine();
            //转换成大写形式
            s1 = s1.ToUpper();
            Console.WriteLine("请输入你喜欢的课程");         
            //小写
            //s1.ToLower();
            string s2 = Console.ReadLine();
            s2 = s2.ToUpper();

            //用==比较的时候区分大小写，需要手动准换
            //Equals不需要，不区分大小写
            if(s1.Equals(s2,StringComparison.OrdinalIgnoreCase)) 
            {
                Console.WriteLine("一样");
            }
            else { Console.WriteLine("不一样"); }

        }
    }
}
