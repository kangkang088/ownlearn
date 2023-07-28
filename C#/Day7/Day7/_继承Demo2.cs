using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class _继承Demo2
    {
        static void Main(string[] args)
        {
            Repoter rep = new Repoter("记者", 34, '男', "偷拍");
            rep.ShowReporter();
            Programmer pro = new Programmer("程序员", 33, '男', 50);
            pro.ShowProgrammer();
            Drivers dri = new Drivers("司机", 38, '男', 50);
            dri.ShowDriver();

        }
    }
}
