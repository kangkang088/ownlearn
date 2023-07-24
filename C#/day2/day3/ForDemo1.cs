using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class ForDemo1
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 100; i < 1000; i++)
            {
                int temp = i;
                int ge = 0;
                int shi = 0;

                ge = temp % 10;
                temp = temp / 10;
                shi = temp % 10;
                temp = temp / 10;

                if (i == temp * temp * temp + shi * shi * shi + ge * ge * ge)
                {
                    sum++;
                    Console.WriteLine("水仙花数是{0}", i);
                }

            }
            Console.WriteLine("有{0}个水仙花数", sum);
        }
    }
}
