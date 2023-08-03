using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //接口就是一个规范，能力。
        }
    }
    public class Person
    {
        public void SayHello()
        {
            Console.WriteLine("我是人类，可以吃喝拉撒睡");
        }
    }
    public class NBAPlayer
    {
        public void KouLan()
        {
            Console.WriteLine("我可以扣篮");
        }
    }
    //学生肯定是继承于人类，但是又想扣篮，又由于类继承的单根性，这时可以考虑把NBA类写成接口。
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
