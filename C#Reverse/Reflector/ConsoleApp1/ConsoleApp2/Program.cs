using System;

namespace ConsoleApp2 {
    //二。Type对象的一些成员
    class Program {
        static void Main(string[] args){
            Type t1 = typeof(Person); //拿到的其实t1其实是Type类的子类的对象
            Type t1Ttpe = t1.GetType(); //编译器自动处理
            Console.WriteLine(t1Ttpe);
            Type t2Ttpe = t1Ttpe.GetType(); //编译器自动处理
            Console.WriteLine(t2Ttpe);
            Console.WriteLine(t1);
            Console.WriteLine(t1.BaseType);
            Console.WriteLine(t1.FullName);
            Console.WriteLine(t1.Name);
            Console.WriteLine(t1.IsAbstract);
        }
    }
    class Person : Program {
        public Person(){
        }
        public Person(string name){
        }
        public String Name { get; set; }
        public int Age { get; set; }
        public void SayHello(){
            Console.WriteLine("Hello,I'm " + this.Name + ",my age is " + this.Age);
        }
    }
}