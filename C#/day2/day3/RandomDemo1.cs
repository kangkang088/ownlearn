using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3
{
    internal class RandomDemo1
    {
        static void Main(string[] args)
        {
            //产生随机数
            Random random = new Random();
            int r = random.Next(0, 10);//包头不包尾
        }
    }
}
