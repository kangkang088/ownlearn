using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public enum Gender
    { 
        男,
        女
    }
    internal class MethodDemo1
    {
        static void Main(string[] args)
        {
            int max = MethodDemo1.GetMax(50, 60);//方法和main函数在同一个类中，类名可以省略
            Console.WriteLine(max);

            string s = "1";
            Gender gender;
            gender = (Gender)Enum.Parse(typeof(Gender),s);
            Console.WriteLine(gender);
        }
       
        /// <summary>
        /// 计算两个整数最大值并返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>返回最大值</returns>
        
        public static int GetMax(int n1, int n2)
        {

            return n1 > n2 ? n1 : n2;
        }
    }
}
