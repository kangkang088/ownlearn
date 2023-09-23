using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16集合的长度问题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);//以count的一倍开辟空间
        }
    }
}
