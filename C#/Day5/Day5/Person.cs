using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Person
    {
        string _name;
        public string Name
        {
            //当你输出属性的值的时候，会调用
            get { return _name; }
            //当你给属性赋值的时候，会调用
            set 
            { _name = value; }
        }
        int _age;
        public int Age
        {
            get { return (int)_age; }
            set 
            {
                if (value < 0 || value > 100)
                { 
                    value = 0;
                }
                _age = value;
            }
        }
        char _gender;
        public char Gender
        {
            get 
            {
                if (_gender != '男' && _gender != '女')
                { 
                    return _gender = '男';
                }
                return _gender; 
            }
            set { _gender = value; }
        }

        public void CHLSS()
        {
            //在这里执行get
            Console.WriteLine("我叫{0}，今年{1}岁了，性别{2}", this.Name, this.Age, this.Gender);
            Console.WriteLine("吃喝拉撒睡");
        }
    }
}
