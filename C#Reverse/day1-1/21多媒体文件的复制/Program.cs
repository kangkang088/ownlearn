using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21多媒体文件的复制
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            byte[] buffer1 = File.ReadAllBytes("C:\\Users\\Administrator\\Desktop\\11.mp4");
            File.WriteAllBytes("C:\\Users\\Administrator\\Desktop\\111.mp4", buffer1);
        }
    }
}
