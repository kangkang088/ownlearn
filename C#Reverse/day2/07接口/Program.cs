using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07接口
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Student student = new Student();
            student.KouLan();
        }
    }
    public class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("我是人类，吃喝拉撒睡");
        }
    }
    public class NBAPlayer
    {
        public void KouLan() { Console.WriteLine("我是球员，可以扣篮"); }
    }
    //学生可以吃喝拉撒睡，但是也可以扣篮。继承的单根性阻止我多继承，我该怎么实现继承扣篮呢？
    //利用接口,可以通过继承一个接口来实现
    //继承的接口中的方法要在类中完成实现
    public class Student : Person, IKouLanable
    {
        public void KouLan()
        {
            Console.WriteLine("我也可以扣篮");
        }
    }
    public interface IKouLanable
    { 
        void KouLan();
    }
}
