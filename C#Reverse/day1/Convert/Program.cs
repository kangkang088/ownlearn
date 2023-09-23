using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Convert
{
    enum Color
    { 
        red = 1,
        green, 
        blue
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            string s = "8";
            int v = Convert.ToInt32(s);
            Console.WriteLine(v);

            //convert内部实际上调用的就是parse函数

            //如果转换的字符串是数字类型，则枚举类型中没有，也不会抛异常
            //如果转换的字符串是文本类型。则枚举类型中没有，会抛出异常
            string m = "red";
            Color c = (Color)Enum.Parse(typeof(Color), m);
            Console.WriteLine(c);

            Console.WriteLine("请输入您喜欢的颜色：1-红色，2-绿色，3-蓝色");
            string str = Console.ReadLine();
            switch (str) 
            {
                case "1":
                    Color color1 = (Color)Enum.Parse(typeof(Color), str);
                    Console.WriteLine("您喜欢的颜色是" + color1);
                    break;
                case "2":
                    Color color2 = (Color)Enum.Parse(typeof(Color), str);
                    Console.WriteLine("您喜欢的颜色是" + color2);
                    break;
                case "3":
                    Color color3 = (Color)Enum.Parse(typeof(Color), str);
                    Console.WriteLine("您喜欢的颜色是" + color3);
                    break;
                default:
                    break;
            }

        }
    }
}
