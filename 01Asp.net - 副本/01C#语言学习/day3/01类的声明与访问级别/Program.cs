using System;

namespace _01类的声明与访问级别 {
    internal class Program {
        static void Main(string[] args) {
            Student student = new Student();

        }
    }
    class Student {
        public int Id { get; set; }
        public string Name { get; set; }
        public void Report() {
            Console.WriteLine($"I'm #{Id} student,my name is{Name}.");
        }
    }

    class MyClass
    {
            
    }
}
