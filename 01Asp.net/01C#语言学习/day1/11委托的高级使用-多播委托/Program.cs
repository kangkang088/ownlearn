using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _11委托的高级使用_多播委托
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student() { Id = 1,PenColor = ConsoleColor.Yellow};    
            Student student2 = new Student() { Id = 2,PenColor = ConsoleColor.Green};    
            Student student3 = new Student() { Id = 3,PenColor = ConsoleColor.Red};

            Action action1 = new Action(student1.DoHomeWork);
            Action action2 = new Action(student2.DoHomeWork);
            Action action3 = new Action(student3.DoHomeWork);

            //单播委托
            action1();
            action2();
            action3();

            //多播委托
            action1 += action2;
            action1 += action3;
            action1();
        }
    }
    class Student
    { 
        public int Id { get; set; }
        public ConsoleColor PenColor { get; set; }

        public void DoHomeWork()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = this.PenColor;
                Console.WriteLine("Studen {0} doing homework {1} hour(s)",this.Id,i);
                Thread.Sleep(1000);
            }
        }
    }
}
