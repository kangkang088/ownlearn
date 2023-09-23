using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            
            Stopwatch sw = Stopwatch.StartNew();
            //sw.Start();
            //string str = null;
            //for (int i = 0; i < 100000; i++) {
            //    str += i;
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);

            //由于字符串的不可变性，大量操作时，大量重复开辟空间，所需要的时间很多，内存大量浪费，用string builder可以解决
            //stringbuilder操作的说同一块空间
            //最后tostring
            StringBuilder sb = new StringBuilder();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.WriteLine(sb.ToString());

        }
    }
}
