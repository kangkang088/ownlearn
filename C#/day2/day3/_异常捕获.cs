using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class _异常捕获
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字：");
            int number = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(number * 2);
            }
            catch
            {
                Console.WriteLine("输入的数字不正确");
            }
            
        }
    }
}
