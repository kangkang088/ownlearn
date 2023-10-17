using System;

namespace ConsoleApp1 {
    class Program {
        //一。lambda表达式
        static void Main(string[] args){
            Action<int> a1 = new Action<int>(delegate(int i) { Console.WriteLine(i); });
            a1.Invoke(3);
            //lambda表达式
            Action<int> a2 = new Action<int>((int i) => { Console.WriteLine(i); });
            a2.Invoke(666);
            //1.类型可以省略
            Action<int> a3 = (i) => { Console.WriteLine(i); };
            //2.只有一个参数，则小括号可以省略
            Action<int> a4 = i => { Console.WriteLine(i); };
            Action<int> a5 = i => { Console.WriteLine(i); };
        }
        Func<string, int, bool> f1 = delegate(string s, int i) { return s.Length == i; };
        Func<string, int, bool> f2 = delegate(string s, int i) { return s.Length == i; };
        Func<string, int, bool> f3 = (string s, int i) => { return s.Length == i; };
        Func<string, int, bool> f4 = (s, i) => { return s.Length == i; };
        //3.有返回值，并且只有一行代码，这行代码是返回值，则大括号和return都可以省略
        Func<string, int, bool> f5 = (s, i) => s.Length == i;
        Func<string, bool> f6 = s => s.Length == 1;
    }
}