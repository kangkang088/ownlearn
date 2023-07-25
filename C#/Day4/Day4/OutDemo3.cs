using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class OutDemo3
    {
        static void Main(string[] args)
        {
            int num;
            bool b = int.TryParse("123", out num);
            Console.WriteLine(b);
            Console.WriteLine(num);
            Console.ReadLine();

            int num1;
            bool b1 = MyTryParse("123as", out num1);
            Console.WriteLine(num1);
            Console.WriteLine(b1);
        }
        /// <summary>
        /// 自己的方法实现TryParse
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <param name="num">转换后所存的地方</param>
        /// <returns></returns>
        public static bool MyTryParse(string s, out int num)
        {
            try
            {
                num = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                num = 0;
                return false;
            }
        }
    }
}
