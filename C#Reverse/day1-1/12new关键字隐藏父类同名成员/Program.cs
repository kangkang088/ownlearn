using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12new关键字隐藏父类同名成员
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Repoter repoter = new Repoter("记者",15,'男',"打篮球");
            repoter.SayHello();
            Console.ReadKey();
        }
    }
    public class Person
    {
        //如果没有这么默认无参构造函数，需要让子类显示调用父类的有参构造函数
        //public Person() { }
        public Person(string name, int age, char gender) { this.Name = name; this.Age = age; this.Gender = gender; }
        private string _name;
        public string Name { get { return this._name; } set { this._name = value; } }
        private int _age;
        public int Age { get { return this._age; } set { this._age = value; } }
        private char _gender;
        public char Gender { get { return this._gender; } set { this._gender = value; } }
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Repoter : Person
    {
        public Repoter(string name, int age, char gender, string hobby) : base(name, age, gender) { this.Hobby = hobby; }
        private string _hobby;
        public string Hobby { get { return this._hobby; }  set{ this._hobby = value; } }
        public new void SayHello()
        {
            Console.WriteLine("我是记者");
        }
    }
    public class Programmer : Person
    {
        public Programmer(string name, int age, char gender, int workerYear) : base(name, age, gender) { this.WorkerYear = workerYear; }
        private int _workerYear;
        public int WorkerYear { get { return this._workerYear; }set { this._workerYear = value; } }
        public new void SayHello()
        {
            Console.WriteLine("我是程序员");
        }
    }
}
