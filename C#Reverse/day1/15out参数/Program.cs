using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15out参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int max = 0, min = 0, sum = 0, avg = 0;
            //注意别忘记out
            GetMaxMinSumAvg(arr,out max,out min,out sum,out avg);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
        }
        //out 当返回多个类型不同的值的时候，可以用out来表示额外返回的值
        //必须在方法中为参数赋值，在方法外声明（同时也可以赋初值，也可以不赋值）
        public static void GetMaxMinSumAvg(int[] arr,out int max,out int min,out int sum,out int avg) 
        {
            max = arr[0]; min = arr[0];sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min) { max = arr[i]; }
                sum += arr[i];
            }
            avg = sum / arr.Length;
        }
    }
}
