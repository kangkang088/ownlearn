using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换
{
    internal class Program
    {
        //1.子类可以赋值给父类
        //2.如果父类中装的是子类对象，那么可以将这个父类强制类型转换为子类
        static void Main(string[] args)
        {
            Student student = new Student();
            //子类赋值给父类
            Person person = student;//如果一个地方需要父类，可以用子类来赋值

            //强转父类为子类对象
            Student ss =  (Student)person;


            
        }
    }
}
