using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19File类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //File.Create("C:\\Users\\Administrator\\Desktop\\laoweiTest.txt");//创建
            //File.Delete("C:\\Users\\Administrator\\Desktop\\laoweiTest.txt");//删除
            //File.Copy("C:\\Users\\Administrator\\Desktop\\长恨歌-jdk.txt", "C:\\Users\\Administrator\\Desktop\\Test.txt");//拷贝现有的文件到一个新文件
        }
    }
}
