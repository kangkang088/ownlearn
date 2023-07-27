using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Ticket
    {
        private double _distance;
        //只读
        public double Distance
        { get { return _distance; } }
        public Ticket(double distance) 
        {
            //只读，不能用属性Distance赋值了，没有set
            if (distance < 0)
            { 
                distance = 0;
            }
            this._distance = distance;
        }
        //票价1/张，计算总价格
        private double _price;
        public double Price
            //只读
        { 
            //可以在get现有的方法里面直接返回价格，不用再单独创建一个计算价格的方法。
            get 
            {
                if (_distance > 0 && _distance <= 100)
                {
                    return _distance * 1.0;
                }
                else if (_distance <= 200)
                {
                    return _distance * 0.95;
                }
                else if (_distance <= 300)
                {
                    return _distance * 0.9;
                }
                else
                    return _distance * 0.8;
                //return _price;//可以去掉
            }          
        }
        public void ShowInfo()
        {
            Console.WriteLine("{0}公里需要{1}元",this.Distance,this.Price);
        }
    }
}
