using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Dem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //将p传输给对方电脑
            //1.序列化对象
            Person p = new Person();
            p.Name = "张三";
            p.Gender = '男';
            p.Age = 30;
            //2.转换为二进制
            using (FileStream fsWrite = new FileStream(@"C:\Users\Administrator\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                //开始序列化对象
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWrite, p);//包括了写入流
            }
            Console.WriteLine("序列化成功");
            //3.模拟对方电脑，接受，并反序列化为对象
            using (FileStream fsRead = new FileStream(@"C:\Users\Administrator\Desktop\111.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter b = new BinaryFormatter();
                Person pp = (Person)b.Deserialize(fsRead);
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Age);
                Console.WriteLine(p.Gender);
            }
        }
    }
}
