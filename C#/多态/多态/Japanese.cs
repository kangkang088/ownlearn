﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    public  class Japanese:Person
    {
        public Japanese(string name):base(name) { }
        public void SayHello()
        {
            Console.WriteLine("我是脚盆人，我叫{0}",this.Name);
        }
    }
}
