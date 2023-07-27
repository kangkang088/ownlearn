using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class StringBuilderDemo2
    {
        static void Main(string[] args)
        {
            //字符串的不可变性决定了不可能对它进行大量的数据处理
            //StringBuilder类解决了这个问题
            StringBuilder stringBuilder = new StringBuilder();
            string str = null;
            //创建一个计时器记录程序运行时间
            Stopwatch sw = new Stopwatch();
            sw.Start();//开始
            for (int i = 0; i < 10000; i++)
            {
                //str += i;//大量的时间
                stringBuilder.Append(i);//很快
            }
            sw.Stop();//结束
            Console.WriteLine(stringBuilder.ToString());//最后往往还要变回字符串
            Console.WriteLine(sw.Elapsed);//获取当前程序运行所需要的时间
        }
                
    }
}
