using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19params可变参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //int[] arr = { 99, 88, 77 };
            //params相当于省略了arr数组的声明和初始化
            //params将这几个数当作数组处理，称为可变参数，方法参数中用可变参数数组来接收，模拟可变，实际不可变
            Test("张三", 99,88,77);

        }
        public static void Test(string name, params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++) { sum += score[i]; }
            Console.WriteLine("{0}这次考试的总成绩是{1}", name, sum);
        }
    }
}
