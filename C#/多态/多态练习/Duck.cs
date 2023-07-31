using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    internal class Duck
    {
        private string _name;
        public string Name { get { return _name; }set { _name = value; } }
        public Duck(string name)
        { 
            this.Name = name;
        }
        virtual public void Show()
        {
            Console.WriteLine("鸭子");
        }
    }
}
