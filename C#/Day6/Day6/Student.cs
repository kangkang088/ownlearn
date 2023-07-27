using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Student
    {
        #region 析构函数
        //构造函数
        public Student() { }
        public Student(string name,int age,char gender,int chinese,int english,int math) 
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Chinese = chinese;
            this.English = english;
            this.Math = math;
        }
        //this
        //1.本类的当前对象
        //2.类中显示的调用构造函数
        public Student(string name, int age, char gender, int chinese):this(name,age,gender,chinese,0,0)//把这个构造函数的参数传给通过this调用包括这些参数的构造函数
            //没有被调用构造函数的参数可以提供默认值
        {            
            //代码冗余，用this解决
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
            //this.Chinese = chinese;         
        }
        public Student(string name, int age, char gender, int chinese, int english):this(name,age,gender,chinese,english,0)
        {
            //代码冗余，用this解决
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
            //this.Chinese = chinese;
            //this.English = english;
        }
        #endregion

        #region
        //析构函数
        //帮助我们释放资源，程序结束时调用
        //GC garba Collection  .NET引入的垃圾回收器 帮助我们释放资源，自动调用，但程序结束时不一定 立刻 释放资源
        //析构函数的作用是程序结束时， 立刻 释放资源
        ~Student() { Console.WriteLine("我是析构函数"); }
        #endregion
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value < 0 && value > 100)
                {
                    value = 0;
                }
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
                    _gender = '男';
                }
                return _gender;
            }
            set { _gender = value; }
        }
        private int _chinese;
        public int Chinese
        {
            set { _chinese = value; }
            get { return _chinese; }
        }
        public int _english;
        public int English
        {
            set { _english = value; }
            get { return _english; }
        }
        private int _math;
        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }

        public void SayHello()
        {
            Console.WriteLine("我叫{0}，我今年{1}岁了，我是{2}生", this.Name, this.Age, this.Gender);
        }
        public void ShowScores()
        {
            Console.WriteLine("我叫{0}，我的总成绩是{1}，平均成绩是{2}", this.Name, this.Math + this.Chinese + this.English, (this.English + this.Chinese + this.Math) / 3);
        }

    }
}
