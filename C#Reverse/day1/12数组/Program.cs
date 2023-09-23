using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            int[] nums = new int[10];
            for (int i = 0; i < nums.Length; i++) { nums[i] = i; }
            for (int i = 0;i < nums.Length; i++) { Console.WriteLine(i); }
        }
    }
}
