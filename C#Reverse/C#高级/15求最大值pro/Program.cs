using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15求最大值pro
{
    public delegate int DelCompare<T>(T t1,T t2);
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int max1 = GetMax<int>(nums, Compare1);
            Console.WriteLine(max1);

            string[] strings = { "eqeqeq", "eqeaodhaoi", "eqjhoijhiofhauodfhaio", "equieh", "diqeeuhnczhudoqwkejwqiejiqwejqipowe" };
            string max2 = GetMax<string>(strings, Compare2);
            Console.WriteLine(max2);

            string max3 = GetMax<string>(strings, (string n1, string n2) => {
                return n1.Length - n2.Length;
            });
            Console.WriteLine(max3);
        }
        public static T GetMax<T>(T[] arr, DelCompare<T> del)
        { 
            T max = arr[0];
            for (int i = 1; i < arr.Length; i++) 
            {
                if (del(max, arr[i]) < 0)
                { 
                    max = arr[i];
                }
            }
            return max;
        }
        public static int Compare1(int n1, int n2)
        {
            return n1 - n2;
        }
        public static int Compare2(string n1, string n2)
        { 
            return n1.Length - n2.Length;
        }
    }
}
