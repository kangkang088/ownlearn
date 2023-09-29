using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _12匿名函数
{
    internal class Program
    {
        public delegate string DelProStr(string name);
        static void Main(string[] args)
        {
            string[] names = { "abcdeFG", "hiJKlMnopQ", "rstUvw", "Xyz" };
            //匿名函数  delegate
            ProStr(names,delegate(string name) 
            {
                return "\" " + name + "\"";
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        public static void ProStr(string[] str,DelProStr del)
        { 
            for (int i = 0;i < str.Length;i++) 
            {
                str[i] = del(str[i]);
            }
        }

        //用委托，虽然实现了一个函数调用另外三个函数，但是好像也是又写了三个函数，而且这三个函数我很大可能只会使用其中任意一个一次，这时可以用匿名函数代替这三个函数。
        //public static string StrToUpper(string name)
        //{ 
        //    return name.ToUpper();
        //}
        //public static string StrToLower(string name)
        //{
        //    return name.ToLower();
        //}
        //public static string StrSYH(string name)
        //{
        //    return "\"" + name +"\"" ;
        //}
    }
}
