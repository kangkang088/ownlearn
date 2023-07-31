using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    internal class Dog:Animals
    {
        public override string Name { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }

        public override void Bark()
        {
            Console.WriteLine("狗旺旺的叫");
        }
    }
}
