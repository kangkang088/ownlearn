using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class ForDemo2
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 7;)
            {
                for (int j = 6; j >= 0; j--)
                {
                    Console.WriteLine("{0}+{1}={2}",i,j,i+j);
                    i++;
                }
                int number = 0;
                bool b = int.TryParse("1234", out number);
                Console.WriteLine(b);
            }
    
        }
    }
}
