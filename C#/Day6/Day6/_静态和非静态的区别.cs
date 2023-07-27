using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class _静态和非静态的区别
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            //调用实例（非静态）成员时，对象名.实例成员
            p.M1();
            //调用静态成员时，类名.静态成员名
            //当静态成员和main函数在同一个类中时，可以省略类名。例如  Console.WriteLine（）；类名.成员名
            Person.M2();
        }
    }
}
