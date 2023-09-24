using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06重写ToString方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Person person = new Person();
            //直接打印对象，默认调用tostring方法，输出对象所在的命名空间,包括对象所在的类名
            Console.WriteLine(person);
            Console.WriteLine(person.ToString());
        }
    }
    public class Person
    {
        public override string ToString()
        {
            return "hello world";
        }
    }
}
