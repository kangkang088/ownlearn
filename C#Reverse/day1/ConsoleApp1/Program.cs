using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("hello world");
            string v = Console.ReadLine();
            Console.WriteLine(v);

            int a = 10;int b = 10;int c = 10;
            Console.WriteLine("第一个数字是{0}，第二个数字是{1}，第三个数字是{2}",a,b,c,30);//多填没效果
            Console.WriteLine("第一个数字是{0}，第二个数字是{1}，第三个数字是{2}",a,b);//少填会出异常，程序会异常终止

            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
