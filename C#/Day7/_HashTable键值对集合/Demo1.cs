using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Hashtable键值对集合
{
    internal class Demo1
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, "男");
            ht.Add(false, "错误的");
            //错误的
            for (int i = 0; i < ht.Count; i++)
            {
                Console.WriteLine(ht[i]);
            }

            //键值对集合中，根据键找值
            Console.WriteLine(ht[1]);
            Console.WriteLine(ht[2]);
            Console.WriteLine(ht[3]);
            Console.WriteLine(ht[false]);
        }
    }
}
