using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    internal class CalBuy : CalFather
    {
        //根据价格
        //买的
        public double M { get; set; }
        //送的
        public double N { get; set; }
        //每买m，送n。不固定，所以需要传
        public CalBuy(double m, double n) { this.M = m; this.N = n; }
        public override double GetTotalMoney(double sumMoney)
        {
            if (sumMoney >= this.M)
            {
                return sumMoney - (int)(sumMoney / this.M) * this.N;
            }
            else
            {
                return sumMoney;
            }    
        }
    }
}
