using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _filestream实现多媒体文件的复制
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.读取要复制的多媒体文件 2.写入指定位置
            string source = @"C:\Users\Administrator\Desktop\复习.wmv";
            string target = @"C:\Users\Administrator\Desktop\new.wmv";
            CopyFile(source, target);
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }
        public static void CopyFile(string source, string target)
        {
            using (FileStream fileRead = new FileStream(source, FileMode.OpenOrCreate, FileAccess.Read))
            {
                using (FileStream fileWriter = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //文件可能会比较大，所有通过循环读
                    while (true)
                    {
                        int r = fileRead.Read(buffer, 0, buffer.Length);
                        if (r == 0)
                        {
                            break;
                        }
                        fileWriter.Write(buffer, 0, r);
                    }
                    

                }
            }
        }
    }
}
