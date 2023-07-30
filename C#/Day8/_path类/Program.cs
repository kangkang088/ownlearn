using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _path类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = @"D:\code\ownlearn\ownlearn\新建文件夹\jpiuo.avi";
            //int index = str.LastIndexOf('\\');
            //str = str.Substring(index+1);
            //Console.WriteLine(str);
            Console.WriteLine(Path.GetFileName(str));//快速获得文件名字
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));//获得文件的名字，不包括扩展名

        }
    }
}
