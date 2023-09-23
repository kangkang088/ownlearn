using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23文件流
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //读数据
            //创建对象
            FileStream fsRead = new FileStream("C:\\Users\\Administrator\\Desktop\\222.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //创建缓冲区大小
            byte[] buffer = new byte[1024 * 1024 * 5];
            //返回实际读取的字节数
            //如果文件有10.5M，缓冲区一遍读5M，第三遍的时候数据只有0.5M,缓冲区还是读5M，
            //剩下的4.5M为空字符
            int num = fsRead.Read(buffer, 0, buffer.Length);
            //将字节数组转为字符串输出
            string str = Encoding.UTF8.GetString(buffer,0,num);
            Console.WriteLine(str);
            fsRead.Close();
            fsRead.Dispose();

            //写数据
            using (FileStream fsWrite = new FileStream("C:\\Users\\Administrator\\Desktop\\noExist.txt", FileMode.Append, FileAccess.Write))
            {
                string str1 = "写入的字符串";
                //转换为字节数组
                byte[] bytes = Encoding.Default.GetBytes(str1);
                fsWrite.Write(bytes, 0, bytes.Length);
                Console.WriteLine("写入完成");
            }
        }
    }
}
