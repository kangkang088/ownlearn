using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22Directory类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //创建
            Directory.CreateDirectory("c:/1");
            //删除
            //文件夹里面有内容时，不可以删除。改为true强制删除
            Directory.Delete("c:/1", true);

            Directory.CreateDirectory("c:/2");
            bool b = Directory.Exists("c:/2");
            Console.WriteLine(b);
            //剪切
            //把2剪切，创建4接受，如果4本来就存在，就会报错
            //Directory.Move("c:/2", "c:/5");

            //获取指定文件夹下所有子文件夹的全路径
            string[] str = Directory.GetDirectories("C:\\Windows");
            //foreach (string str2 in str) { Console.WriteLine(str2); }
            //获取指定文件夹下的所有文件的全路径或文件夹下的指定文件类型的所有文件全路径
            string[] str_S = Directory.GetFiles("C:\\Windows", "*.exe");
            foreach (string str3 in str_S) { Console.WriteLine(str3); }
        }
    }
}
