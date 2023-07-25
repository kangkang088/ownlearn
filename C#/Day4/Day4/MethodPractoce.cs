using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class MethodPractoce
    {
        static void Main(string[] args)
        {
            //用方法计算数组的平均值，保留两位小数
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 }; 
            double avg = GetAvg(num);
            string s = avg.ToString("0.00");
            Console.WriteLine(s);
        }
        public static double GetAvg(int[] arr) 
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            double avg = 0;
            avg = sum / arr.Length;
            return avg;
        }
    }
}
