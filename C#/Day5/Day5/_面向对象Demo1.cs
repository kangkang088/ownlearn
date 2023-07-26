using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class _面向对象Demo1
    {
        static void Main(string[] args)
        {
            //Person s;
            
            Person p = new Person();
            //避免直接访问数据
            //这里set
            p.Name = "张三";
            p.Age = 22;
            p.Gender = '春';
            p.CHLSS();
        }
    }
}
