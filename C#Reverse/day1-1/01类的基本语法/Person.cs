using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _01类的基本语法
{
    public class Person
    {
        string _name;
        //属性
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        int _age;
        public int Age
        {
            get { return this._age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                this._age = value;
            }
        }
        char _gender;
        //通过属性来设置字段
        public char Gender
        {
            //当你输出属性的值的时候，会执行get方法
            get {
                if (this._gender != '男' && this._gender != '女')
                {
                    this._gender = '男';
                    return this._gender ;
                }

                return this._gender; }
            //给属性赋值时首先调用set方法
            set { this._gender = value; }
        }

        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
            Console.WriteLine("我叫{0}，我今年{1}岁，性别{2}", this.Name, this.Age, this.Gender);
        }
    }
}
