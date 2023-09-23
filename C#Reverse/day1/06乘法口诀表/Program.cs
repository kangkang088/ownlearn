using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06乘法口诀表
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i  + "*" + j + "=" + i * j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
