using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\b");
            Console.WriteLine("创建成功");
            Directory.Delete(@"c:\b",true);
            Console.WriteLine("删除成功");
            Directory.Move(@"c:\a", @"C:\Users\Administrator\Desktop\a");
            Console.WriteLine("剪切成功");
            
            Console.ReadKey();
        }
    }
}
