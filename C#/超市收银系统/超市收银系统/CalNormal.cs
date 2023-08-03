using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class CalNormal:CalFather
    {
        //不打折
        public override double GetTotalMoney(double sumMoney)
        {
            return sumMoney;
        }
    }
}
