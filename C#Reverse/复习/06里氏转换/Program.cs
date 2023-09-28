using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06里氏转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.子类可以赋值给父类
            //2.父类中装的是子类对象，可以将父类强制转换为子类

            Person person = new Person();
            person.Name = "Test";
            Student student = new Student();
            student.Name = "Test";
            student.Id = 1;
            Teacher teacher = new Teacher();
            teacher.Name = "Test";
            teacher.Salary = 1;

            Person person1 = new Student();
            Student student1 = (Student)person1;
            Console.WriteLine(student1.Id);

            Person person2 = new Student();
            Teacher teacher1 = person2 as Teacher;//null    
            if (person2 is Student)
            {
                Console.WriteLine("可以");
            }
            else
            {
                Console.WriteLine("不可以");
            }


        }
    }
    public class Person
    { 
        public string Name { get; set; }
    }
    public class Student : Person
    {
        public int Id { get; set; }
    }
    public class Teacher : Person
    { 
        public double Salary { get; set; }
    }
}
