using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Student : Person
    {
        public Student(string name, int age, char gender, int id) : base(name, age, gender)
        {
            this.Id = id;
        }
        //private string _name;
        //private int _age;
        //private char _gender;
        private int _id;
        //public string Name { get { return _name; } set { _name = value; } }
        //public int Age { get { return _age; } set { _age = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        //public char Gender { get { return _gender; } set { _gender = value; } }
        //public void CHLSS()
        //{
        //    Console.WriteLine("吃喝拉撒睡");
        //}
        public void Study()
        {
            Console.WriteLine("学习");
        }
    }
}
