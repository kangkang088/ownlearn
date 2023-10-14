using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0505具名参数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInfo("Tim", 34);//不具名调用
            PrintInfo(name: "Tom", age: 35);//具名调用
            PrintInfo(age: 35, name: "Tom");//具名调用
            //1.提高代码可读性
            //2.不受参数列表的顺序约束
        }
        static void PrintInfo(string name, int age)
        {
            Console.WriteLine("Hello {0},you are {1}",name,age);
        }
    }
}
