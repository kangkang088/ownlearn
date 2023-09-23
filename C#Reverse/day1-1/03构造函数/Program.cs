using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03构造函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //new  在内存中开辟一块空间，后创建对象，对象调用构造函数
            Student student1 = new Student("张三",25,'男',100,100,100);

            //太繁琐了，构造函数完美解决
            //student1.Name = "张三";
            //student1.Age = 25;
            //student1.Gender = '男';
            //student1.English = 100;
            //student1.Chinese = 100;
            //student1.Math = 100;
            student1.SayHello();
            student1.ShowScore();
        }
    }
}
