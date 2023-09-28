using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12FileStream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using (FileStream fsRead = new FileStream("C:\\Users\\Administrator\\Desktop\\111.txt", FileMode.OpenOrCreate, FileAccess.Read))
            //{
            //    byte[] bytes = new byte[1024 * 1024 * 5];
            //    //有效字节数
            //    int r = fsRead.Read(bytes, 0, bytes.Length);
            //    string str = Encoding.UTF8.GetString(bytes,0,r);
            //    Console.WriteLine(str);
            //}

            //using (FileStream fsWrite = new FileStream("C:\\Users\\Administrator\\Desktop\\xie.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str = "她";
            //    byte[] bytes = Encoding.UTF8.GetBytes(str);
            //    fsWrite.Write(bytes, 0, bytes.Length);
            //}
            //Console.WriteLine("写入成功");


            //using (FileStream fsRead = new FileStream("C:\\Users\\Administrator\\Desktop\\111.txt", FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fsRead,Encoding.UTF8))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            Console.WriteLine(sr.ReadLine());
            //        }
            //    }
            //}

            
            //using (StreamWriter sw = new StreamWriter("C:\\Users\\Administrator\\Desktop\\streamxie.txt"))
            //{
            //    sw.WriteLine("我w");
            //}
            //Console.WriteLine("写入成功");
            
        }
    }
}
