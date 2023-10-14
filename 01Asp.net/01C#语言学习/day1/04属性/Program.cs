using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04属性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Student student = new Student();
                student.Age = 121;
                Console.WriteLine(student.CanWork);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
    }
    class Student
    {
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value;CalculateCanWork(); }
            
        }
        private bool canWork;
        public bool CanWork
        {
            get
            {
                return canWork;
            }
        }
        private void CalculateCanWork()
        { 
            if(this.age >= 16)
                this.canWork = true;
            else this.canWork = false;
        }

    }
}
