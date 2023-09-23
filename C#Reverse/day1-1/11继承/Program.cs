using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Student s = new Student("张三",25,'男',1500);



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
    }
    public class Student : Person
    {
        public Student(string name, int age, char gender, int id) : base(name, age, gender) { this.Id = id; }
        private int _id;
        public int Id { get { return this._id; } set { this._id = value; } }
        public void Study()
        {
            Console.WriteLine("学习");
        }
    }
    public class Teacher : Person
    {
        public Teacher(string name, int age, char gender, double salary) : base(name, age, gender) { this.Salary = salary; }
        private double _salary;
        public double Salary { get { return this._salary; } set { this._salary = value; } }
        public void Teach()
        {
            Console.WriteLine("讲课");
        }
    }
    public class Driver : Person
    {
        public Driver(string name, int age, char gender, double driverYear) : base(name, age, gender) { this.DirverYear = driverYear; }
        private double _dirverYear;
        public double DirverYear { get { return this._dirverYear; } set { this._dirverYear = value; } }
        public void DriverCar()
        {
            Console.WriteLine("开车");
        }
    }
}
