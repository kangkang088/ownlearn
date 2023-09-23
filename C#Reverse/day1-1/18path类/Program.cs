using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18path类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            string str = "c:/sd/awewq/eqwrfeadw/fsvfg/sdfadw/laozhao.wav";
            //获得文件名包含扩展名
            string strName = Path.GetFileName(str);
            Console.WriteLine(strName);
            //获得文件名不包含扩展名
            string strName_s = Path.GetFileNameWithoutExtension(str);
            Console.WriteLine(strName_s);
            //获得文件的扩展名
            string strName1 = Path.GetExtension(str);
            Console.WriteLine(strName1);
            //获得文件所在的文件夹的目录
            string strName2 = Path.GetDirectoryName(str);
            Console.WriteLine(strName2);
            //获得文件所在的绝对路径（全路径）
            string strName3 = Path.GetFullPath(str);
            Console.WriteLine(strName3);
            //将两个字符串链接为一个路径
            Console.WriteLine(Path.Combine("c:/a/laowei/","b.txt"));
            
        }
    }
}
