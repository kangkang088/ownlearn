using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib1
{
    public class Class1
    {
        public void Test()
        {
            Console.WriteLine(typeof(FileStream).Assembly.Location);
        }
    }
}
