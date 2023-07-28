using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{

    public class Teacher:Person
    {
        public Teacher(string name, int age, char gender, double salary) : base(name, age, gender)
        {
            this.Salary = salary;
        }
        //private string _name;
        //private int _age;
        //private char _gender;
        private double _salary;
        //public string Name { get { return _name; }set { _name = value; } }
        //public char Gender { get { return _gender; } set { _gender = value; } }
        //public int Age { get { return _age; } set { _age = value; } }
        public double Salary { get { return _salary; } set { _salary = value; } }
        //public void CHLSS()
        //{
        //    Console.WriteLine("吃喝拉撒睡");
        //}
        public void Teach()
        {
            Console.WriteLine("教书");
        }
    }
}
