using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04面向对象与继承
{
    internal class Person
    {
        //字段 属性 构造函数 方法 接口
        string _name;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (value != "孙权")
                { value = "孙权"; }
                this._name = value;
            }
        }
        int _age;
        public int Age
        {
            get
            {
                if (this._age < 0 || this._age > 100)
                {
                    return this._age = 0;
                }
                return this._age;
            }
            set { this._age = value; }
        }
        char _gender;
        public char Gender { get { return this._gender; } set { this._gender = value; } }
        int _math;
        public int Math { get { return this._math; } set { this._math = value; } }
        int _english;
        public int English { get { return this._english; } set { this._english = value; } }
        int _chinese;
        public int Chinese { get { return this._chinese; } set { this._chinese = value; } }
        public Person(string name, int age, char gender, int math, int english, int chinese)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Math = math;
            English = english;
            Chinese = chinese;
        }
        public Person(string name, int age, char gender) : this(name, age, gender, 0, 0, 0)
        { }

        public Person(char gender)
        {
            if (gender != '男' && gender != '女')
            {
                gender = '男';
            }
            this.Gender = gender;
        }
        public Person() { }
        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁，性别{2}。", this.Name, this.Age, this.Gender);
        }
    }
}
