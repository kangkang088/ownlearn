using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08产生随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Random rnd = new Random();
            int v = rnd.Next(1,2);
            Console.WriteLine(v);
        }
    }
}
