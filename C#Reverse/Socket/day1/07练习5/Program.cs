using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07练习5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = GetMax(10, 20);
            Console.WriteLine(max);
            int max1 = GetMax(10, 20, 30, 40);
            Console.WriteLine(max1);
        }
        public static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }
        public static int GetMax(params int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }
    }
}
