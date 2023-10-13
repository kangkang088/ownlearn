using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = { "qeqe", "qe7q8", "qweqw98e" };
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(5, "15");
            Console.WriteLine(d.Values.First());
            string[] strs2 = { "" };
            Console.WriteLine(strs2.Length);
        }
    }
}
