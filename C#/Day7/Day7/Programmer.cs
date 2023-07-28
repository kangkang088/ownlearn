using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Programmer:Persons
    {
        private int _workYears;
        public int WorkYears { get { return _workYears; }set { _workYears = value; } }
        public Programmer(string name, int age, char gender,int workYears) :base(name,age,gender)
            {
            this.WorkYears = workYears;
        }
        public void ShowProgrammer()
        {
            Console.WriteLine("我是{0}，我的工作时间是是{1}，我是{2}生，我今年{3}岁了", this.Name, this.WorkYears, this.Gender, this.Age);
        }
    }
}
