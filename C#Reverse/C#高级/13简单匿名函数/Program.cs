using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13简单匿名函数
{
    public delegate void DelSayHi(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            //SayHi("张三", SayHiChinese);
            //Console.ReadKey();

            //思考，下面这种方式好像并不需要SayHi这个函数呀，那我们先把这个函数注释掉，同时注释掉上面的调用。。
            //继续思考，我们既然用了委托，就是不想出现多个及其类似的函数，这样的话下面的这种调用好像并没有和委托相呼应，那我们能不能把函数也去掉呢？我们先注释掉下面两个相似的函数
            //匿名函数可以完美实现
            //注意匿名函数的签名和委托一样
            DelSayHi del = delegate (string name)
            {
                Console.WriteLine("你好" + name);
            };
            del("李四");

            //继续思考，还能不能继续简化？可以。
            //lamda表达式 (参数)=>{}
            DelSayHi del2 = (string name) => { Console.WriteLine("你好" + name); };
            del2("张三");


        }
        //public static void SayHi(string name,DelSayHi del)
        //{
        //    del(name);
        //}
        //public static void SayHiChinese(string name) 
        //{
        //    Console.WriteLine("你好" + name);
        //}
        //public static void SayHiEnglish(string name)
        //{
        //    Console.WriteLine("Hello" + name);
        //}
    }
}
