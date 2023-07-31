using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    public class Person
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }
        public Person(string name) 
        {
            this.Name = name;
        }
        virtual public void SayHello()
        {
            Console.WriteLine("你好");
        }
    }
}
