using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _泛型集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list  = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.AddRange(new int[] { 1,2,3,4,5,6});
            list.AddRange(list);
        }
    }
}
