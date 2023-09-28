using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _13序列化和反序列化
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //类添加可序列化标记
            Person person = new Person();
            person.Name = "Test";
            person.Age = 10;
            person.Gender = '男';
            using (FileStream fsWrite = new FileStream("C:\\Users\\Administrator\\Desktop\\xuliehua.txt", FileMode.OpenOrCreate, FileAccess.Write))
            { 
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fsWrite, person);
            }
            Console.WriteLine("序列化成功");

            Person p;
            using (FileStream fsRead = new FileStream("C:\\Users\\Administrator\\Desktop\\xuliehua.txt", FileMode.Open, FileAccess.Read))
            { 
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                p = (Person)binaryFormatter.Deserialize(fsRead);
            }
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Gender);
        }
    }
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
    }
}
