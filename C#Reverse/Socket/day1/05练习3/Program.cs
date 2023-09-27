using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05练习3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10; int b = 20;
            Swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        public static void Swap(ref int a, ref int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
        }
    }
}
