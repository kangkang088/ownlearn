using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10枚举
{
    enum Color {red,green,blue};
    internal class Program
    {

        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            //和int可以互相转换
            Color color = Color.red;
            Console.WriteLine((int)color);

            int a = 10;
            Color c  = Color.green;
            c = (Color)a;
            Console.WriteLine(c);


        }
    }
}
