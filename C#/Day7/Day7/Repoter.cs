using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Repoter:Persons
    {
        public Repoter(string name,int age,char gender,string hobby):base(name,age,gender) 
        {
        this.Hobby = hobby;
        }
        private string _hobby;
        public string Hobby { get { return _hobby; } set { _hobby = value; } }
        public void ShowReporter()
        {
            Console.WriteLine("我是{0}，我的爱好是{1}，我是{2}生，我今年{3}岁了",this.Name,this.Hobby,this.Gender,this.Age);
        }
    }
}
