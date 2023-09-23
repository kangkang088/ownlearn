using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27dictionary集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Dictionary<int, double> d = new Dictionary<int, double>();
            d.Add(1, 1.5);
            d.Add(2, 1.56);
            d.Add(3, 1.6);
            d.Add(4, 1.67);
            d.Add(5, 1.7);
            d.Add(6, 1.78);
            d[7] = 1.8;
            d[8] = 1.89;
            foreach (int i in d.Keys) { Console.WriteLine(i); }
            foreach (double i in d.Values) { Console.WriteLine(i); }
            foreach (KeyValuePair<int, double> item in d) { Console.WriteLine("键{0}，值{1}",item.Key,item.Value); }
        }
    }
}
