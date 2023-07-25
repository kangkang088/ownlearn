using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public enum Gender
    { 
        男,
        女
    }
    public struct Person
    {
        public string name;
        public int age;
        public Gender gender;
    }
    internal class StructDemo1
    {
        static void Main(string[] args)
        {
            Person zsPerson;
            zsPerson.name = "张三";
            zsPerson.age = 10;
            zsPerson.gender = Gender.男;
            Person lsPerson;
            lsPerson.name = "李四";
            lsPerson.age = 10;
            lsPerson.gender = Gender.男;
                
            
        }
    }
}
