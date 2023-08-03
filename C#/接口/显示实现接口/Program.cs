using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace 显示实现接口
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //解决接口方法重名问题
            SupererPerson person = new Person();
            //显示实现接口了，所以是超人飞
            person.Fly();
            //没有显示实现接口了，所以人飞
            IFly fly = new Person();
            fly.Fly();
            //要人飞
            Person person1 = new Person();
            person1.Fly();

        }

    }
    public class Person : IFly, SupererPerson
    {
        //普通实现
        public void Fly()
        {
            Console.WriteLine("人飞");
        }
        //void IFly.Fly() { Console.WriteLine("。可以飞"); }
        //显示实现
        void SupererPerson.Fly() { Console.WriteLine("超人飞"); }
    }
    public interface IFly
    {
        void Fly();
    }
    public interface SupererPerson
    {
        void Fly();
    }
    public class Student { }
    public class Teacher { }
}
