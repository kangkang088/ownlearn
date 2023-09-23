using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07质数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            for (int i = 2; i < 101; i++) 
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    Console.WriteLine("质数：" + i);
                }
            }
        }
    }
}
