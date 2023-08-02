using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double char int decimal struct enum bool  栈
            //string 数组 自定义类 集合 object 接口 堆

            Person p1 = new Person();//p1在栈中，存储堆中对象的地址
            p1.Name = "张三";//堆中给对象赋值
            Person p2 = p1;//这条代码是指将p1的引用传递给了p2，使得栈中的p1和p2存储的内容相同-指向堆中的同一块区域的地址。即p1和p2指向的是同一个对象
            p2.Name = "李四";//改变p2.Name，p1.Name也会改变，因为p1和p2指向堆中同一块区域
            Console.WriteLine(p1.Name);//李四
            Console.WriteLine(p2.Name);//李四


            int a = 10;
            int b = a;
            b = 20;
            Console.WriteLine(a);//10
            Console.WriteLine(b);//20


            Person p3  = new Person();
            p3.Name = "张三";
            Test(p3);
            Console.WriteLine(p3.Name);

        }
        public static void Test(Person pp)
        {
            Person p = pp;
            p.Name = "李四";
        }
    }
}
