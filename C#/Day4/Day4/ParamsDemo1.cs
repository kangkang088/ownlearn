using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class ParamsDemo1
    {

        //params
        //将实参列表中跟可变参数数组类型一致的元素都当作数组的元素去处理。
        //实参直接传数组也可以

        static void Main(string[] args)
        {
            Test("张三", 99, 88, 77);
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            int max = 0;
            GetMax(ref max, 11, 88, 6, 54, 9, 47, 6, 48, 4, 165);
            Console.WriteLine(max);
        }

        //参数数组必须是形参列表中的最后一个元素
        //如果参数数组后面还有形参，程序无法识别参数数组和另一个形参的区别
        public static void Test(string name,params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++) 
            {
                sum += arr[i];
            }
            Console.WriteLine("{0}这次考试的总成绩为{1}",name,sum);
        }

        //求任意长度数组的最大值，整型数组的
        public static void GetMax(ref int max ,params int[] arr)
        {
            max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                { 
                    max = arr[i];
                }
            }
        }
    }
}
