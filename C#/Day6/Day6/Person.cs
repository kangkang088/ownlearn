using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    //在非静态类中，既可以有实例成员，也可以有静态成员
    //静态类中，不允许实例成员，静态类不允许被实例化
    //因为静态类创建对象没有意义，静态类里面的所以成员都要用类名去调用

    //使用静态类：1.类当作工具类（经常使用，如Console）时，该类写为静态类
    //2.做项目时，静态类在整个项目中，资源共享。静态类不会有对象，本身占内存（堆，栈，静态存储区，位于静态存储区），在整个项目中，都可以访问静态存储区
    //3.静态类会一直占用资源，只有在程序全部结束后才会释放资源
    //GC garbage collection 垃圾回收器，来负责释放资源 
    public class Person
    {
        private static int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _Name;
        public string Name
        { get { return _Name; } set {  _Name = value; } }
        //非静态方法里面都可以访问
        public void M1()
        {

            Console.WriteLine("我是一个非静态方法");

        }
        //静态方法里面可以方法静态成员和属性，不可以访问非静态成员和属性
        public static void M2()
        {
            Console.WriteLine("我是一个静态方法");
        }
    }
}
