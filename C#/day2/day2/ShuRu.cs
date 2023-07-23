using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class ShuRu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个数字：");
            string str1 = Console.ReadLine();
            Console.WriteLine(str1);
            Console.WriteLine("请输入一个数字：");
            string str2 = Console.ReadLine();
            Console.WriteLine(str2);      
            //int 类型来计算
            //Parse();转换为int
            int sum = int.Parse(str1) + int.Parse(str2);
            Console.WriteLine("int类型的结果为：");
            Console.WriteLine(sum);
            //string 类型来计算
            //Tostring();转换为string
            //int其实会自动转换为string,不用Tostring();
            string add = str1 + str2 + 20.ToString();            
            Console.WriteLine("string类型的结果为：");
            Console.WriteLine(add);
            
        }
    }
}
