using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04面向对象与继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person('中');
            p.Name = "张三";
            p.Age = 10;
            p.SayHello();

        }
    }
}
