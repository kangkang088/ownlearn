using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03练习1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("请输入您的考试成绩：");
            int socre = Convert.ToInt32(Console.ReadLine());
            string result = GetLevel(socre);
            Console.WriteLine(result);

            //2.
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("i * j =" + i * j + "\t");
                }
                Console.WriteLine();
            }

            //3.
            int[] nums = new int[50];
            Random random = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = random.Next(0, 10);
            }
            Console.WriteLine("请输入一个数字：");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                Console.Write(nums[i] + " ");
                sum++;
                if (sum >= number)
                {
                    Console.WriteLine();
                    sum = 0;
                }
            }
        }
        public static string GetLevel(int score)
        {
            string level = null;
            if (score >= 90)
            {
                level = "优";
            }
            else if (score >= 80)
            {
                level = "良好";
            }
            else if (score >= 70)
            {
                level = "中";

            }
            else if (score >= 60)
            {
                level = "差";
            }
            else
            {
                level = "不及格";
            }
            return level;
        }
    }
}
