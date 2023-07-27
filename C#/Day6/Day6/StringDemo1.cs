using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class StringDemo1
    {
        static void Main(string[] args)
        {
            string s1 = "张三";
            string s2 = "张三";
            Console.ReadKey();

            //可以看作一个char类型的只读数组
            string str1 = "afrawewaewae";
            Console.WriteLine(str1[1]);//f

            //先将字符串转换为char数组，即可读又可写
            //但不会影响到上面的字符串
            char[] c1 = str1.ToCharArray();
            c1[1] = 'a';
            //要改写字符串，再转回字符串
            str1 = new string(c1);
            Console.WriteLine(str1[1]);//a
        }
    }
}
