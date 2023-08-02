using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 设计模式
{
    internal class Lenovo:NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }
}
