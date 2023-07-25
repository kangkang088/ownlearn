using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day4
{
    internal class OutDemo1
    {
        //out侧重于返回多个类型不同的值
        static void Main(string[] args)
        {
            //写一个方法，求数组中的最大值，最小值，总和，平均值
            //如何一次在一个方法里面返回四个值
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //返回的四个值放到数组中
            int[]info = GetMaxMinSumAvg(numbers);
            Console.WriteLine("最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}", info[0], info[1], info[2], info[3]);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //out的方法
            int max = 0;int min = 0;int sum = 0;int avg = 0;string name;
            OutTest(numbers, out max, out min, out sum, out avg,out name);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);
            Console.WriteLine(avg);
            Console.WriteLine(name);

        }
        public static int[] GetMaxMinSumAvg(int[] arr)
        {
            int[] ints = new int[4];
            //假设ints[0] 最大值   ints[1] 最小值  ints[2] 总和 ints[3] 平均值
            ints[0] = arr[0];//最大值
            ints[1] = arr[0];//最小值
            ints[2] = 0;//总和
            for (int i = 0; i < arr.Length; i++)
            {
                //求最大值
                if (arr[i] > ints[0])
                {
                    ints[0] = arr[i];
                }
                //求最小值
                if (arr[i] < ints[1])
                {
                    ints[1] = arr[i];
                }
                //总和
                ints[2] += arr[i];
            }
            //平均值
            ints[3] = ints[2] / arr.Length;
            return ints;
        }
        /// <summary>
        /// 求最大值最小值总和平均值
        /// </summary>
        /// <param name="numbers">传递的数组</param>
        /// <param name="max">最大值</param>
        /// <param name="min">最小值</param>
        /// <param name="sum">总和</param>
        /// <param name="avg">平均值</param>
        /// <param name="name">不同类型的数据 名字</param>
        //out
        //该方法没有返回值，形参列表里面用out来表示多余返回的值
        //方法内部必须为out参数赋值
        public static void OutTest(int[] numbers, out int max, out int min, out int sum, out int avg, out string name)
        {
            max = numbers[0];
            min = numbers[0];
            sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                //求最大值
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
                //求最小值
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                //总和
                sum += numbers[i];
            }
            //平均值
            avg = sum / numbers.Length;
            name = "张三";
        }

    }
}
