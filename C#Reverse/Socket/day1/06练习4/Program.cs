using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06练习4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串：");
            string str = Console.ReadLine();
            int num = Count(str);
            Console.WriteLine(num);

        }
        public static int Count(string str)
        {
            return str.Length;
        }
    }
}
