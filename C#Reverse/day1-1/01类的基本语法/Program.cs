using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _01类的基本语法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Person person;
            person = new Person();
            person.Name = "孙权";//
            person.Age = 23;
            person.Gender = 'a';
            person.CHLSS();
            Console.ReadKey();
            


        }
    }
}
