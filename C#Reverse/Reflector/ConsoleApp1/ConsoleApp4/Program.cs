using System;
using System.Reflection;

namespace ConsoleApp4 {
    //四。利用反射模拟PropertyGrid控件
    class Program {
        static void Main(string[] args){
            Person p1 = new Person();
            p1.Name = "kangkang";
            p1.Age = 18;
            ShowObject(p1);
        }
        static void ShowObject(object obj){
            Type type = obj.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (PropertyInfo item in propertyInfos){
                if (item.CanRead){
                    string propName = item.Name;
                    object propValue = item.GetValue(obj);
                    Console.WriteLine(propName + "=" + propValue);
                }
            }
        }
    }
    class Person {
        public Person(){
        }
        public Person(string name){
            this.Name = "lisi";
        }
        public String Name { get; set; }
        public int Age { get; set; }
        public void SayHello(){
            Console.WriteLine("Hello,I'm " + this.Name + ",my age is " + this.Age);
        }
    }
}