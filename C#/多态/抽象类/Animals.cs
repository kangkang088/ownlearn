using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    internal abstract class Animals//抽象类
    {
        public abstract void Bark();//抽象方法
        public abstract string Name
        { 
            get; set;
        }
    }
}
