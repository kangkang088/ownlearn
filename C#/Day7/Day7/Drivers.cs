using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Drivers : Persons
    {
        private int _driverYears;
        public int DriverYears { get { return _driverYears; } set { _driverYears = value; } }
        public Drivers(string name, int age, char gender, int driverYears) : base(name, age, gender)
        {
            this.DriverYears = driverYears;
        }
        public void ShowDriver()
        {
            Console.WriteLine("我是{0}，我的工作时间是是{1}，我是{2}生，我今年{3}岁了", this.Name, this.DriverYears, this.Gender, this.Age);
        }
    }
}
