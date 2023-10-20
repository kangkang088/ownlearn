using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07LinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 11,21,13,14,15,16};
            bool b = intList.All(x => x > 10);//All并不是List的，而是扩展方法（this），是一个Linq方法
            Console.WriteLine(b);
        }
        static bool AllGreaterThanTen(List<int> intList)
        { 
            foreach (int i in intList) 
            {
                if (i <= 10)
                    return false;
            }
            return true;
        }
    }
}
