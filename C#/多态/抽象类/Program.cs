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

            //
            Shape shape = new Circle(5);
            double a = shape.Area();
            double b = shape.Perimeter();
            Console.WriteLine("面积是{0}，周长是{1}",a,b);
            Shape shape1 = new Square(5,10);
            double m = shape1.Perimeter();
            double n = shape1.Area();
            Console.WriteLine("面积是{0}，周长是{1}",n,m);
        }
    }
}
