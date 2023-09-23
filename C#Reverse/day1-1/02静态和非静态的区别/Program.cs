using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02静态和非静态的区别
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
            person.M1();
            //main方法和静态方法不在同一个类中时，要用类名.方法名来调用
            Person.M2();
        }

    }
}
