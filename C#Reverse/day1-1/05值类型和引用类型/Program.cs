using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05值类型和引用类型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //值类型：int bool char double decimal struct enum 栈
            //引用类型：string 自定义类  数组 堆
        }
    }
}
