using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace 语法特征
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //接口不能被实例化
            //多态
            IFlyable flyable = new Person();
            flyable.Fly();

        }
    }
    public class Person : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人在飞");
        }
    }
    public class Bird : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("鸟在飞");
        }
    }
    public interface IFlyable
    {
        //不允许有访问修饰符，默认public
        //只允许有方法，自动属性...
        void Fly();
    }
    public interface M1
    { void Test1(); }
    public interface M2 { void Test2(); }
    public interface M3 { void Test3(); }
    public interface SupererInterface : M1, M2, M3
    { 
       //不可以实现继承的接口方法，在能在类中实现
    }
    public class Car : SupererInterface
    {
        public void Test1()
        {
            throw new NotImplementedException();
        }

        public void Test2()
        {
            throw new NotImplementedException();
        }

        public void Test3()
        {
            throw new NotImplementedException();
        }
    }
}
