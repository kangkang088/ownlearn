using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16lamda表达式
{
    public delegate void DelOne();
    public delegate void DelTwo(string name);
    public delegate string DelThree(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            DelOne delOne = delegate () { };
            DelOne delOneLamda = () => { };

            DelTwo delTwo = delegate (string name) { };
            DelTwo delTwoLamda = (string name) => { };

            DelThree delThree = delegate (string name) { return name; };
            DelThree delThreeLamda = (string name) => { return name; };

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            list.RemoveAll(n => n > 4);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
