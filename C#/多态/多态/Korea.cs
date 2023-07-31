using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    public class Korea:Person
    {
       public Korea(string name):base(name) { }
        public void SayHello()
        {
            Console.WriteLine("我是好历任，我叫{0}",this.Name);
        }
    }
}
