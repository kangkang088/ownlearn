using System;
using System.Linq;

namespace ConsoleApp5 {
    //五。集合的其他扩展方法
    class Program {
        static void Main(string[] args){
            string str1 = "656464654qw";
            Console.WriteLine(str1.First());//获取集合的第一个元素
            string str2 = "";
            //Console.WriteLine(str2.First());//如果集合为空，抛异常
            string str3 = "";
            Console.WriteLine(str3.FirstOrDefault());//如果为空，返回集合默认值，string是null，int是0.
            string str4 = "5";
            Console.WriteLine(str4.Single());//获取集合唯一一个元素，如果集合为空或有多个，抛异常
            string str5 = "";
            Console.WriteLine(str4.SingleOrDefault());//获取集合唯一一个元素，如果集合为空，返回默认值，多个，还是抛异常。
        }
    }
}