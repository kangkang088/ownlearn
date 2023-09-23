using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04调试
{
    internal class Program
    {
        static void Main(string[] _args)
        {
            if (_args is null)
            {
                throw new ArgumentNullException(nameof(_args));
            }

            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine(i);
            }
            Show();
        }
        public static void Show()
        {
            Console.WriteLine("hello world");
        }
    }
}
