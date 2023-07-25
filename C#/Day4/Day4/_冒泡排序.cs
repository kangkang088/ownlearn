using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class _冒泡排序
    {
        static void Main(string[] args)
        {
            //将一个数组中的元素按一定顺序排序

            int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //趟数：元素个数-1
            for (int i = 0; i < nums.Length - 1; i++)
            {
                //每趟比较的次数：i从0开始，比较9次
                //i=1，比较8次。
                //i+j=9=length-1
                //j=length-1-i
                //因为j从0开始，则小于不等于
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] >= nums[j+1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j+1];
                        nums[j+1] = temp;
                        
                    }
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
