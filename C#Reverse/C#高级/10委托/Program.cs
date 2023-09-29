using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace _10委托
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //三个需求，1.字符串数组中每个元素都转换成大写
            //2.字符串数组中每个元素都小写
            //3.字符串数组中每个元素两边都加上双引号
            string[] names = { "abcdeFG", "hiJKlMnopQ", "rstUvw", "Xyz" };
            //ProStrToUpper(names);
            //ProStrToLower(names);
            ProStrSYH(names);
            for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine(names[i]);
            }
        }
        //三个函数不同的无非就是for循环里面的等号右边的函数调用，有没有一种方法，让我们使用一个函数，然后for循环等号右边的函数调用取决于我们在函数中传递的内容
        //实现：把方法作为参数传递给另一个方法，方法参数的类型，就是委托类型
        public static void ProStrToUpper(string[] str)
        { 
            for (int i = 0; i < str.Length; i++) 
            {
                str[i] = str[i].ToUpper();
            }
        }
        public static void ProStrToLower(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].ToLower();
            }
        }
        public static void ProStrSYH(string[] str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = "\"" + str[i] + "\"";
            }
        }
    }
}
