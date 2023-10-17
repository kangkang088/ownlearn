using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3 {
    //三。集合常用扩展方法
    class Program {
        static void Main(string[] args){
            //1.
            List<int> list = new List<int>{3,9,8,16,99};
            foreach (int i in list.Where(i=>i>10)){
                Console.WriteLine(i);
            }
            //2.
            IEnumerable<string> ieInts = list.Select(i => i + "...");
            foreach (string item in ieInts){
                Console.WriteLine(item);
            }
            //3.自己扩展Select
            List<string> list1 = new List<string>{"15","16","17"};
            IEnumerable<string> data = MySelect.MySelect_s(list1, i => i + "...");
            foreach (string VARIABLE in data){
                Console.WriteLine(VARIABLE);
            }
            
        }
    }
    static class MySelect {
        public static IEnumerable<T> MySelect_s<T>(this IEnumerable<T> data, Func<T, T> func){
            List<T> list = new List<T>();
            foreach (T item in data){
                list.Add(func(item));
            }
            return list;
        }
    }
}