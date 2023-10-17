using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4 {
    class Program {
        //四，类数组扩展方法
        static void Main(string[] args){
            Person[] persons = new[] { new Person(8, "baidu"), new Person(10, "wangyiyun"), new Person(15, "xinlang") };
            int sum = persons.MySum_s(p => p.Age);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
    class Person {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(int age, string name){
            Age = age;
            Name = name;
        }
    }
    static class MySum {
        public static int MySum_s<T>(this IEnumerable<T> data, Func<T, int> func){
            int sum = 0;
            foreach (T person in data){
                sum += func(person);
            }
            return sum;
        }
    }
}