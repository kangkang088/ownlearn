using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24Filestream实现对媒体复制
{
    internal class Program
    {

        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            string source = "C:\\Users\\Administrator\\Desktop\\22.mp4";
            string des = "C:\\Users\\Administrator\\Desktop\\55.mp4";
            FileCopy(source, des);
        }
        public static void FileCopy(string sourcePath,string desPath)
        {
            using (FileStream fsRead = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream fsWrite = new FileStream(desPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    //先读到内存缓冲区，再写入
                    byte[] buffer = new byte[1024 * 1024 * 7];
                    //一次读7兆，当文件大于7兆时，要读多次
                    //直到读取的字符为0
                    
                   
                    while (true)
                    {
                        //循环将源文件中的数据读取到缓冲区，一次读的大小和缓冲区大小一致
                        int num = fsRead.Read(buffer, 0, buffer.Length);
                        if (num == 0)
                        {
                            return;
                        }
                        else { 
                            //把每一次缓冲区的实际数据写入到文件
                            fsWrite.Write(buffer, 0, num);
                        }
                    }

                }
            }
        }
    }
}
