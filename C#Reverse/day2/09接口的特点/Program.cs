using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09接口的特点
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //1.接口不可以被实例化对象,接口中成员没有任何实现。为了多态。
            //IFlyable flyable = new IFlyable();
            IFlyable flyable1 = new Person();
            IFlyable flyable2 = new Bird();
            flyable1.Fly();
            flyable2.Fly();
        }
    }
    public class Person :IFlyable
    {
        public void Fly() { Console.WriteLine("人飞"); }
    }
    //4.类可以同时继承接口和类，但继承语法必须是类在任何接口之前
    public class Student:Person,IFlyable { }
    public class Bird:IFlyable 
    {
        public void Fly() { Console.WriteLine("鸟飞"); }
    }
    public interface IFlyable
    {
        void Fly();
    }
    //2.接口可以继承接口，并且可以多继承。接口不能继承类
    public interface M1 { void test1(); }
    public interface M2 { void test2(); }
    public interface M3 { void test3(); }
    public interface SuperInterface:M1,M2,M3 { }
    //3.实现接口的子类，必须实现该接口的所有成员
    public class Car : SuperInterface
    {
        public void test1()
        {
            throw new NotImplementedException();
        }

        public void test2()
        {
            throw new NotImplementedException();
        }

        public void test3()
        {
            throw new NotImplementedException();
        }
    }
}
