using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class _方法的重载
    {
        //方法的名称相同，参数不同(个数||类型)
        //使代码更有通用性
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
        public static void Add(int m,int n) 
        {
            
        }
        public static void Add(double m,double n)
        {

        }
        public static void Add(int m,int n,int s)
        {

        }
        public static void Add(double m,double n,double s)
        {

        }
        public static void Add(string s1,string s2)
        {

        }
        public static void Add(string s1,string s2,int m)
        {

        }
    }
}
