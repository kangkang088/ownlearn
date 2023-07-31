using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.抽象类
            Animals animals = new Dog();
            animals.Bark();//依然表现出来父类的方法，调用父类的方法，但是父类是虚基类，方法被重写。
        }
    }
}
