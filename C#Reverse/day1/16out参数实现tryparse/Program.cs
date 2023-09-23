using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16out参数实现tryparse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            int num;
            bool b = int.TryParse("123", out num);
            Console.WriteLine(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }
        public static bool MyTryparse(string str, out int num)
        {
            try
            {
                num = Convert.ToInt32(str);
                return true;
            }
            catch
            {
                num = 0;
                return false;
            }
        }
    }
}
