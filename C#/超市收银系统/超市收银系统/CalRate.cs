using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class CalRate:CalFather
    {
        //根据折扣率
        public double Rate { get; set; }
        public CalRate(double rate) { this.Rate = rate; }
        public override double GetTotalMoney(double sumMoney)
        {
            return this.Rate * sumMoney;
        }
    }
}
