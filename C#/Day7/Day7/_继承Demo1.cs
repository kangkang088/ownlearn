using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class _继承Demo1
    {
        //继承的作用是解决  类的代码冗余
        //老师，学生，司机等等各种职业的类几乎都有name，age，gender，CHLSS()这几个属性和方法
        //把这些共有的属性和方法封装成一个类作为父类

        //
        static void Main(string[] args)
        {
            Student s = new Student("学生",18,'男',101);
            

        }
    }
}
