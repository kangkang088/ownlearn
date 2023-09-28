using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory("C:\\Users\\Administrator\\Desktop\\新建文件夹");

            //Directory.Delete("C:\\Users\\Administrator\\Desktop\\新建文件夹", true);

            //Directory.CreateDirectory("C:\\Users\\Administrator\\Desktop\\新建文件夹");
            //Directory.Move("C:\\Users\\Administrator\\Desktop\\新建文件夹", "C:\\Users\\Administrator\\Desktop\\新建文件夹1");

            string[] str = Directory.GetFiles("C:\\Users\\Administrator\\Desktop","*.txt");
            foreach (string str2 in str) { Console.WriteLine(str2); }
        }
    }
}
