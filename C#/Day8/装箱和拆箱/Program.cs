using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装箱和拆箱
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //装箱：将值类型转换为引用类型
            //拆箱：将引用类型转换为值类型
            int n = 10;
            object o = n;//装箱
            int nn = (int)o;//拆箱
            Stopwatch sw = new Stopwatch();
            sw.Start();
            ArrayList list = new ArrayList();
            //List<int> ints = new List<int>();
            for (int i = 0; i < 10000000; i++)
            {
                list.Add(i);//i被转换为object类型
                //装箱操作
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }
    }
}
