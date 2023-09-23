using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20File类的读写
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //将文件以二进制的形式读取到字节数组
            byte[] bytes = File.ReadAllBytes("C:\\Users\\Administrator\\Desktop\\Test.txt");
            //将二进制转变为字符串
            string strBytes = Encoding.UTF8.GetString(bytes);
            Console.WriteLine(strBytes);
            //将文件按行读取，一次读取一行
            string[] str = File.ReadAllLines("C:\\Users\\Administrator\\Desktop\\Test.txt",Encoding.UTF8);
            foreach (string line in str) { Console.WriteLine(line); }
            //将文件以文本格式读取，返回字符串
            string strText = File.ReadAllText("C:\\Users\\Administrator\\Desktop\\Test.txt", Encoding.UTF8);
            Console.WriteLine(strText);
            //将字符串以二进制形式写入文件，覆盖
            string str2 = "今天真是好热锕";
            byte[] bytes2 = Encoding.UTF8.GetBytes(str2);
            File.WriteAllBytes("C:\\Users\\Administrator\\Desktop\\Test2.txt", bytes);
            Console.WriteLine("写入成功");
            //将字符串数组中的每个元素按行写入文件，覆盖原内容
            string[] names = { "张三", "李四", "王五", "赵六" };
            File.WriteAllLines("C:\\Users\\Administrator\\Desktop\\Test2.txt", names);
            //将字符串写入一个文件，有就覆盖，没有就创建
            File.WriteAllText("C:\\Users\\Administrator\\Desktop\\Test2.txt", "明天休息");

            //追加写入
            File.AppendAllText("C:\\Users\\Administrator\\Desktop\\Test2.txt","追加的内容");
        }
    }
}
