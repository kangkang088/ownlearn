using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    
    internal class _简繁转换
    {
        private const string jian = "委屈恶趣味为";
        private const string fan = "我问请我器我";
        static void Main(string[] args)
        {
            //根据键（简体）找值（繁体）-键值对集合实现简繁转换
            Hashtable ht = new Hashtable();
            for (int i = 0; i < jian.Length; i++)
            {
                ht.Add(jian[i], fan[i]);
            }
            Console.WriteLine("请输入");
            string input = Console.ReadLine();
            //要判断输入的简体字，在简体字数组里面有没有，没有，就无法转换成繁体字
            for (int i = 0;i < input.Length;i++) 
            {
                if (ht.ContainsKey(input[i]))
                {
                    Console.WriteLine(ht[input[i]]);
                }
                else
                {
                    Console.WriteLine(input[i]);
                }
            }

        }
    }
}
