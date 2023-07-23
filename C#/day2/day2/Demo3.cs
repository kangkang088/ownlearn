using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Demo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入姓名：");
            string name = Console.ReadLine();
            Console.WriteLine("姓名是{0}",name);


            Console.WriteLine("您喜欢吃什么水果？");
            string fruits = Console.ReadLine();
            Console.WriteLine("您喜欢吃的水果是{0}", fruits);
            Console.ReadKey();

            //转义字符  \+特殊字符
            // \n 换行
            // \r\n windows系统的，文件写入\输出时用到
            // \" 英文双引号
            // \t 一个tab
            // \b 退格，字符串两端不起作用
            // \\ 表示一个\

            string a = "加强啊哈";
            string b = "啊大大加强啊哈";
            string c = "加强啊的撒法俄国哈";
            string d = "加强啊的撒法wqeqwe俄国哈";
            Console.WriteLine("{0}\t\t{1}",a,b);
            Console.WriteLine("{0}{1}",c,d);

            //   \太多容易混乱
            string path = "F:\\A\\C\\d\\e\\c\\ss";
            Console.WriteLine(path);
            
            
            //@取消\的转移作用
            string path_s = @"f;a\s\w\t\y\us\aew\av.avi";
            Console.WriteLine(path_s);

            //@将字符串按照原来的格式输出
            Console.WriteLine(@"法饿饭哈
                尔哦惊扰而骄傲i俄空军哦i");



        
          

        }
    }
}
