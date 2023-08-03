using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Guid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //产生一个不会重复的编号
            Guid guid = Guid.NewGuid();
            Console.WriteLine(guid.ToString());
        }
    }
}
