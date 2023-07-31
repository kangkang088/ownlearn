using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    internal class EraseDuck:Duck
    {
        public EraseDuck(string name):base(name) { }
        public override void Show()
        {
            Console.WriteLine("我是{0}，唧唧叫",this.Name);
        }
    }
}
