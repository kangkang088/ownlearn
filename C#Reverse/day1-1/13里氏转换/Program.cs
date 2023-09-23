using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _13里氏转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            Student student = new Student();
            student.StudentSayHello();
            student.PersonSayHello();

            Person person = new Person();
            person.PersonSayHello();

            //里氏转换
            //1.子类可以赋值给父类  
            Person p1 = new Student();
            //2.父类中装的是子类对象，则父类可以强制转换为子类
            //is  转换成功，返回true，否则false
            if (p1 is Student)
            {
                Student s1 = (Student)p1;
                s1.StudentSayHello();
            }
            else { Console.WriteLine("转换失败"); }
            //as 转换成功，返回对应的对象，否则，null
            Student ss = p1 as Student;
            ss.StudentSayHello();
            
        }
    }
    public class Person
    {
        public void PersonSayHello() { Console.WriteLine("我是人类"); }
    }
    public class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }
    public class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
}
