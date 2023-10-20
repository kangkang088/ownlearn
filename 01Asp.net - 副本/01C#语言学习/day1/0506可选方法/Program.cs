using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0506扩展方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14159;
            double y = Math.Round(x, 4);//Round方法，double没有，怎么让double具有这个方法呢？
            double yy = x.Round(4);
            Console.WriteLine(y);
            Console.WriteLine(yy);
        }
    }
    static class DoubleExtension
    {
        public static double Round(this double x, int y)
        {
            double resuit = Math.Round((double)x, y);
            return resuit;
        }
    }
}
