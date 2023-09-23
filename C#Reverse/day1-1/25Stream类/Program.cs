using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25Stream类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //使用streamreader来读取数据
            //1.
            //using (FileStream fsRead = new FileStream("C:\\Users\\Administrator\\Desktop\\222.txt", FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader streamReader = new StreamReader(fsRead, Encoding.UTF8))
            //    {
            //        //不到流尾就一直读
            //        while (!streamReader.EndOfStream)
            //        {
            //            //循环读，不然只读一行
            //            Console.WriteLine(streamReader.ReadLine());
            //        }
            //    }
            //}

            //2.
            //using (StreamReader stream1 = new StreamReader("C:\\Users\\Administrator\\Desktop\\222.txt", Encoding.UTF8))
            //{
            //    while (!stream1.EndOfStream)
            //    {
            //        Console.WriteLine(stream1.ReadLine());
            //    }
            //}

            //streamWriter 写数据
            //1.
            using (FileStream fsWrite = new FileStream("C:\\Users\\Administrator\\Desktop\\222222.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fsWrite, Encoding.Unicode))
                {
                    //覆盖方式是只覆盖二次写入的相应的字符数
                    //就是有几个字符覆盖几个字符
                    sw.Write("hahahahahahhahahhahahahaha");
                }
            }
            //2.
            using (StreamWriter streamWriter = new StreamWriter("C:\\Users\\Administrator\\Desktop\\222222.txt"))
            {
                //全部覆盖，有几个字符覆盖几个字符
                streamWriter.Write("好好");
            }
        }
    }
}
