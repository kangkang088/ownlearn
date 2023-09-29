using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _14使用委托求数组的最大值
{
    public delegate int DelCompare(object o1,object o2);
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            object[] array = { 1, 54, 8889, 48, 4, 6, 478, 84, 5, 65, 496 };
            object result = GetMax(array, Compare1);
            Console.WriteLine(result);
            //2.用匿名函数
            object result1 = GetMax(array, delegate (object o1, object o2)
            {
                int n1 = (int)o1;
                int n2 = (int)o2;
                return n1 - n2;
            });
            Console.WriteLine(result);
            //3.lamda表达式
            object result2 = GetMax(array, (object o1, object o2) => {
                int n1 = (int)o1;
                int n2 = (int)o2;
                return n1 - n2;
            });
            Console.WriteLine(result2);
        }
        public static object GetMax(object[] arr,DelCompare del)
        {
            object max = arr[0];
            for(int i = 1;i < arr.Length; i++) 
            {
                if (del(max, arr[i]) < 0) 
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int Compare1(object o1, object o2)
        {
            int n1 = (int)o1;
            int n2 = (int)o2;
            return n1 - n2;
        }
        public static int Compare2(object o1, object o2)
        {
            string n1 = (string)o1;
            string n2 = (string)o2;
            return n1.Length - n2.Length;
        }
    }
}
