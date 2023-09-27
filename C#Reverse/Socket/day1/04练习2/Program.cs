using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04练习2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串");
            string s = "SSWEfqew";
            string newStr = GetString(s);
            Console.WriteLine(newStr);
        }
        public static string GetString(string str)
        {
            string str1 = str.Substring(0, 1).ToLower();
            return str1 + str.Substring(1);

        }
    }
}
