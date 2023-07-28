using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Driver:Person
    {
        public Driver(string name, int age, char gender, double driveTime) : base(name, age, gender)
        {
            this.DriveTime = driveTime;
        }
        private double _driveTime;
        public double DriveTime { get { return _driveTime; }set { _driveTime = value; } }
        //private string _name;
        //public string Name { get { return _name; } set { _name = value; } }
        //private int _age;
        //public int Age { get { return _age; } set { _age = value; } }
        //private char _gender;
        //public char Gender { get { return _gender; }set { _gender = value; } }
        //public void CHLSSS()
        //{
        //    Console.WriteLine("吃喝拉撒睡");
        //}
        public void Drive() 
        {
            Console.WriteLine("开车");
        }
    }
}
