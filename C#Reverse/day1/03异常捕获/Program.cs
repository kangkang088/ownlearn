using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("请输入一个数字：");

            int number;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number * 2);
            }
            catch
            {
                Console.WriteLine("错误异常");
            }
            
            Console.ReadKey();
        }
    }
}
