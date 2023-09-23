using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06string方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            string str = "abcdefg";
            //只读
            Console.WriteLine(str[0]);
            //想改，需要变为字符数组
            char[] c = str.ToCharArray();
            //可写，改的是c字符数组，字符串str没变
            c[0] = 'm';
            //改变str
            //将字符数组变为字符串
            str = new string(c);
            Console.WriteLine(str);
        }
    }
}
