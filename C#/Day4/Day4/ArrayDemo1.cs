using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class ArrayDemo1
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10] { 15, 78, 6, 48, 71, 3, 54, 456, 46, 8 };
            int max = nums[0];
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] >= max)
                {
                    max = nums[i];
                }
            }
            for (int i = 1; i < nums.Length; i++)
            {
                if (min >= nums[i])
                {
                    min = nums[i];
                }
            }
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            Console.WriteLine("总值是{0}", sum);
            Console.WriteLine("平均值是{0}", sum / nums.Length);
            Console.WriteLine("最大值是{0}", max);
            Console.WriteLine("最小值是{0}", min);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string[] name = { "老杨", "老苏", "老马", "老魏", "老刘" };
            Console.Write("(");
            for (int i = 0; i < name.Length; i++)
            {

                if (i < name.Length - 1)
                {
                    Console.Write("{0}{1}", name[i], ",");
                }
                else
                {
                    Console.Write("{0}{1}", name[i], ")");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            int[] arr1 = new int[5] { 1, -5, 79, -5, 0 };
            Console.WriteLine("更改前的数组");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] > 0)
                {
                    arr1[i] += 1;
                }
                else if (arr1[i] < 0)
                {
                    arr1[i] -= 1;
                }
            }
            Console.WriteLine("更改后的数组");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            string[] str2 = { "我", "是", "好", "人" };
            for (int i = 0; i < str2.Length / 2; i++)
            {
                string temp = str2[i];
                str2[i] = str2[str2.Length - 1 - i];
                str2[str2.Length - 1 - i] = temp;
            }
            for (int i = 0; i < str2.Length; i++)
            {
                Console.WriteLine(str2[i]);
            }
        }
    }
}
