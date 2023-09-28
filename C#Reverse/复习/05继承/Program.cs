using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace _05继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Person
    {
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name { get; set; }
        public char Gender { get; set; }
        public int Age { get; set; }
        public void CHLSS() { }
    }
    public class Student : Person
    {
        public Student(string name, int age, char gender, int id) : base(name, age, gender)
        { 
            this.Id = id;
        }
        public int Id { get; set; }
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
    }
    public class Teacher : Person
    {
        public Teacher(string name, int age, char gender, double salary) : base(name, age, gender)
        { 
            this.Salary = salary;
        }
        public double Salary { get; set; }
        public void CHLSS()
        {
            Console.WriteLine("老师也是这样的");
        }
    }
}
