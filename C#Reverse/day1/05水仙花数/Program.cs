using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05水仙花数
{
    internal class Program
    {
        static void Main(string[] _args)
        {
            if (_args is null)
            {
                throw new ArgumentNullException(nameof(_args));
            }

            for (int i = 100; i <= 999; i++)
            {
                int ge = i % 10;
                int shi = i % 100 / 10;
                int bai = i / 100;
                if (ge * ge * ge + shi * shi * shi + bai * bai * bai == i)
                {
                    Console.WriteLine("水仙花数： " + i);
                }
            }
        }
    }
}
