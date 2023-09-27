using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08练习6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = GetSum();
            Console.WriteLine(sum);
            int sumJ = GetSumJ();
            Console.WriteLine(sumJ);
            int sumO = GetSumO();
            Console.WriteLine(sumO);
            bool b = isZhi(13);
            if (b)
            {
                Console.WriteLine("是质数");
            }
            else { Console.WriteLine("不是质数"); }
        }
        public static int GetSum()
        {
            int sum = 0;
            for (int i = 0; i < 101; i++) { sum += i; }
            return sum;
        }
        public static int GetSumJ()
        {
            int sum = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                sum += i;
            }
            return sum;
        }
        public static int GetSumO()
        {
            int sum = 0;
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 != 0)
                {
                    continue;
                }
                sum += i;
            }
            return sum;
        }
        public static bool isZhi(int num)
        {
            if (num < 2)
            { 
                return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
