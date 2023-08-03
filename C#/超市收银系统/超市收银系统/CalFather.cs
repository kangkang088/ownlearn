using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    abstract class CalFather
    {
        /// <summary>
        ///计算打折后应付多少前 
        /// </summary>
        /// <param name="sumMoney">打着前应付的前</param>
        /// <returns>打折后应付的钱</returns>
        public abstract double GetTotalMoney(double sumMoney);

    }
}
