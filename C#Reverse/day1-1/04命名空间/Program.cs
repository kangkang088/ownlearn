using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03构造函数;

namespace _04命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }


            List<int> list = new List<int>();
            Student student = new Student("张三",100,100,100);

        }
    }
}
