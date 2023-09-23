using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03构造函数
{
    public class Student
    {
        public Student(string name,int age,char gender,int chinese,int math,int english) 
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.Math = math;
            this.English = english;
        }
        public Student(string name, int chinese, int math, int english) : this(name, 0, 'c', chinese, math, english)
        {
            ////代码冗余，用this解决
            //this.Name = name;                   
            //this.Chinese = chinese;
            //this.Math = math;
            //this.English = english;
        }

        //GC garbage collection 垃圾回收器，程序结束后一段时间后由它自动帮助我们释放资源
        //析构函数程序结束后马上释放资源
        
        ~Student() { Console.WriteLine("析构函数"); }
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 || value > 100)
                { value = 0; }
                _age = value;
            }
        }
        private char _gender;
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
        private int _chinese;
        public int Chinese
        {
            get { return _chinese; }
            set { _chinese = value; }
        }
        private int _math;
        public int Math { get { return _math; } set { _math = value; } }
        private int _english;
        public int English { get { return _english; } set { _english = value; } }

        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生",this.Name,this.Age,this.Gender);

        }
        public void ShowScore()
        {
            Console.WriteLine("{0}的总成绩是{1}，平均成绩是{2}",this.Name,this.English + this.Math + this.Chinese, (this.English + this.Math + this.Chinese) / 3);
        }
    }
}
