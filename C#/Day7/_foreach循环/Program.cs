using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _foreach循环
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, true);
            ht.Add(3, "男");
            ht.Add(false, "错误的");
            
            //根据值
            foreach (var i in ht.Values) 
            {
                Console.WriteLine(i);
            }
            //根据键
            foreach (var i in ht.Keys)
            {
                Console.WriteLine(ht[i]);
            }
        }
    }
}
