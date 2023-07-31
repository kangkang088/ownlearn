using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    internal class MuDuck:Duck
    {
        public MuDuck(string name):base(name) { }
        public override void Show()
        {
            Console.WriteLine("我是{0}，吱吱叫",this.Name);
        }
    }
}
