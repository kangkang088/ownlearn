using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //方法和main函数在同一个类时，类名可以省略
            Show();
        }
        static void Show()
        {
            //writeline是一个方法，调用时要用类名.方法名的形式调用
            //因为writeline方法和main函数不在同一个类下
            Console.WriteLine("1111111");
            Console.WriteLine("1111111");
            Console.WriteLine("1111111");
            Console.WriteLine("1111111");
            Console.WriteLine("1111111");
            Console.WriteLine("222");
            Console.WriteLine("222");
            Console.WriteLine("222");
            Console.WriteLine("1111111");
            Console.WriteLine("1111111");
            Console.WriteLine("1111111");
            Console.WriteLine("1111111");
        }
    }
}
