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
            Student student1 = new Student() { Id = 1, PenColor = ConsoleColor.Yellow };
            Student student2 = new Student() { Id = 2, PenColor = ConsoleColor.Green };
            Student student3 = new Student() { Id = 3, PenColor = ConsoleColor.Red };

            Task task1 = new Task(new Action(student1.DoHomeWork));
            Task task2 = new Task(new Action(student2.DoHomeWork));
            Task task3 = new Task(new Action(student3.DoHomeWork));

            task1.Start();
            task2.Start();
            task3.Start();


            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Main Thread {0}",i);
                Thread.Sleep(1000);
            }
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
                Console.WriteLine("Studen {0} doing homework {1} hour(s)", this.Id, i);
                Thread.Sleep(1000);
            }
        }
    }
}
