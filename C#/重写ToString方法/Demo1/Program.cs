using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
    public class Person 
    {
        public override string ToString()
        {
            return "HelloWorld";
        }
    }
}
