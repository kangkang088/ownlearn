using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class MethodDemo2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数字");
            string input = Console.ReadLine();
            int number1 = Input(input);
            Console.WriteLine(number1);

            int[] arr = { 1, 5, 6, 489, 7, 67, 65 };
            int max = GetMax(arr);
            Console.WriteLine(max);
        }
        /// <summary>
        /// 读取用户输入的是否是数字，如果是，则返回数字，否则提示重新输入
        /// </summary>
        /// <returns>返回值 </returns>
        public static int Input(string s)
        {

            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
            }


        }
        /// <summary>
        /// 求数组中的最大值
        /// </summary>
        /// <param name="arr">需要判断的数组</param>
        /// <returns>返回最大值</returns>
        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] > max)
                { 
                    max = arr[i];
                    
                }
            }
            return max;
        }
        
    }

}
