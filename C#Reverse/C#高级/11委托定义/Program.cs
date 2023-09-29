using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11委托定义
{
    //声明一个委托指向一个函数 注意：委托指向的函数必须跟委托具有相同的签名
    public delegate void DelSayHi(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            //可以直接将函数赋给委托变量，等价于new一个委托并且括号里填函数名
            //DelSayHi del = SayHiChinese;// = new DelSayHi(SayHiChinese);
            //del("张三"); 


            //从上面可以得知，委托可以直接=一个函数  
            //实现将一个函数作为参数，传递给另一个函数。作为参数的函数的类型是委托类型。函数可以赋值给一个委托。
            Test("张三",SayHiChinese);

        }
        public static void Test(string name, DelSayHi del)
        {
            //调用
            del(name);
        }
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了吗？" + name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice tp meet you!" + name);
        }

    }
}
