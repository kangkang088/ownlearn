using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _filestream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //读取数据
            //第一个参数：文件路径。第二个参数：对文件的操作。第三个参数：读\写
            FileStream fileStream = new FileStream(@"C:\Users\Administrator\Desktop\new.txt",FileMode.OpenOrCreate,FileAccess.Read);
            byte[] buffer = new byte[1024*1024*5];
            //返回本次实际读取到的有效字节数
            int r = fileStream.Read(buffer, 0, buffer.Length);
            //将字节数组中每一个元素按照指定的编码格式解码成字符串
            //实际还是读5兆，但只解码0-r。
            string s = Encoding.UTF8.GetString(buffer,0,r);
            //关闭流
            fileStream.Close();
            //释放流所占用的资源
            fileStream.Dispose();
            Console.WriteLine(s);


            //写入数据
            using (FileStream file = new FileStream(@"C:\Users\Administrator\Desktop\new.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "看完有没有覆盖";
                byte[] buff = Encoding.UTF8.GetBytes(str);
                file.Write(buff, 0, buff.Length);
                Console.WriteLine();
            }
        }
    }
}
