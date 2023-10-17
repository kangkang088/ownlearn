using System;
using System.Dynamic;
using System.Reflection;

namespace ConsoleApp3 {
    //三。反射调用实例1
    class Program {
        static void Main(string[] args){
            Type t1 = typeof(Person);
            object o = Activator.CreateInstance(t1);//new Person()-1.创建对象，通过t1指向person
            PropertyInfo propertyInfoName = t1.GetProperty("Name");//获得属性
            propertyInfoName.SetValue(o,"rupeng");//给属性赋值并设置给对象o
            
            object o2 = t1.GetConstructor(new Type[0]).Invoke(new object[0]);//第二个对象（第二种创建方式）
            PropertyInfo propertyInfoAge = t1.GetProperty("Age");//获得属性
            propertyInfoAge.SetValue(o2,18);//给属性赋值并设置给对象o2

            MethodInfo methodInfoSayHello = t1.GetMethod("SayHello", new Type[0]);//获得方法
            methodInfoSayHello.Invoke(o, new object[0]);//在o指向的对象上调用SayHello方法
            methodInfoSayHello.Invoke(o2, new object[0]);//在o2指向的对象上调用SayHello方法
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