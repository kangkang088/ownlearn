using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04部分类
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
        //部分类，两个类共同组成一个类，实质是一个类，所有的成员都要按照在一个类中的规则进行创建
        public partial class Person
        { 
        }
        public partial class Person { }
    }
}
