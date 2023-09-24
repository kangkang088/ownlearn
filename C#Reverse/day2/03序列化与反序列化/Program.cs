using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _03序列化与反序列化
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Person p = new Person();
            p.Name = "张三";
            p.Age = 25;
            p.Gender = '男';
            //目的：传输数据
            //序列化：将对象转化为二进制
            //将p传输给对方电脑
            //1.设置标记[serializable]
            using (FileStream fsWrite = new FileStream("C:\\Users\\Administrator\\Desktop\\序列化.txt", FileMode.OpenOrCreate, FileAccess.Write))
            { 
                //2.开始序列化对象为二进制，写到文件中，模拟发送
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWrite, p);
            }
            Console.WriteLine("序列化完成");
            //反序列化：将二进制转换为对象
            //3.读取文件，模拟接受过程
            Person p1;
            using (FileStream fsRead = new FileStream("C:\\Users\\Administrator\\Desktop\\序列化.txt", FileMode.OpenOrCreate, FileAccess.Read))
            { 
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                p1 = (Person)binaryFormatter.Deserialize(fsRead);
            }
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);
            Console.WriteLine(p1.Gender);
            Console.WriteLine("反序列化成功");
        }
    }
    [Serializable]
    public class Person
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private int _age;
        public int Age { get { return _age; } set { _age = value; } }
        private char _gender;
        public char Gender { get { return _gender; } set { _gender = value; } }
    }
}
