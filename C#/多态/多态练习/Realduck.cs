using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    internal class Realduck:Duck
    {
        public Realduck(string name):base(name) { }
        public override void Show()
        {
            Console.WriteLine("我是{0}，嘎嘎叫",this.Name);
        }
    }
}
