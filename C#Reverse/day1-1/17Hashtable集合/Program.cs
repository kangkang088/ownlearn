using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17Hashtable集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, 15);
            hashtable.Add(2, true);
            hashtable.Add(3, 15m);
            hashtable.Add(4, "156");
            hashtable.Add(5, '男');
            hashtable.Add("ads", 'a');
            //根据键
            foreach (var item in hashtable.Keys) { Console.WriteLine(hashtable[item]); }
            //根据值
            foreach (var item in hashtable.Values) { Console.WriteLine(item); }
        }
    }
}
