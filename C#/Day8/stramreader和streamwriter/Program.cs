using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stramreader和streamwriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //读取文本文件
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Administrator\Desktop\streamtext.txt",Encoding.UTF8))
            {
                while(!streamReader.EndOfStream)

                    Console.WriteLine(streamReader.ReadLine());//只读一行，所有循环，判断是否到流尾
            }

            //写入文本文件
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\Desktop\streamtext.txt",true))
            {
                sw.Write("看看我有没有覆盖");//覆盖写入,在对象构造函数第二个参数加true，就不会覆盖，而是追加
            }
            Console.WriteLine();
        }
    }
}
