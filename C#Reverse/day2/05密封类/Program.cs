using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05密封类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
        }
        
    }
    public sealed class Person { }
    //密封类不能被继承
    //public class Student:Person { }

    //密封类可以继承别人
    public class Teacher { }
    public sealed class Person2:Teacher { }
}
