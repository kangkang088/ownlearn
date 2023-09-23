using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13冒泡排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int[] nums = { 1, 35, 8, 48, 4, 64, 79, 74, 9, 45 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] < nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++) { Console.WriteLine(nums[i]); }

        }
    }
}
