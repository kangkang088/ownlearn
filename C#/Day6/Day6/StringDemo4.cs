using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class StringDemo4
    {
        static void Main(string[] args)
        {
            string str = "1235    + 5 4 8 4   ==   5 -";
            //分割字符串
            char[] arr = { ' ','=','+','-'};
            //按照arr的内容来分割成若干个字符串
            string[] strs = str.Split(arr,StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("请输入日期");
            string data = "2008-08-08";
            char[] chars = { '-'};
            string[] datas = data.Split(chars, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("{0}年{1}月{2}日", datas[0], datas[1], datas[2]);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            string str1 = "国家冠军人物老韩";
            if(str1.Contains("老韩"))
                {
                str1 = str1.Replace("老韩", "**");
            }
            Console.WriteLine(str1);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //SubString  截取字符串
            string str2 = "今天天气晴朗，风景优美。";
            str2 = str2.Substring(0,2);//包含头,不包尾
            Console.WriteLine(str2);
            //str2 = str2.Substring(2);//包含头,直到最后
            //Console.WriteLine(str2);

            //以某个字符开始或结束
            string str3 = "afrwaefawe";
            bool b1 = str3.StartsWith("a");
            Console.WriteLine(b1);
            bool b2 = str3.EndsWith("e");
            Console.WriteLine(b2);


            //判断字符串中某个字符第一次出现的位置

            int index = str3.IndexOf("f");
            Console.WriteLine(index);

            //判断字符串中某个字符最后一次出现的位置
            int lastIndex = str3.LastIndexOf("f");
            Console.WriteLine(lastIndex);


            //lastindexof 和 substring
            string s = @"c:\d\a\苍w\e\t苍\q\t\d苍h\a\苍老师.avi";
            int n = s.LastIndexOf("\\");
            s = s.Substring(n+1);
            Console.WriteLine(s);

            //移除当前字符串的空格
            string m1 = "                   hahahhahahahh           ";
            m1 = m1.Trim();//移除所有的空格
            //m1 = m1.TrimStart();//移除前面的所有空格
            //m1 = m1.TrimEnd();//移除后面的所有空格

            //是否为null或者空
            string m2 = null;
            if (string.IsNullOrEmpty(m2))
            {
                Console.WriteLine("是");
            }
            else
            {
                Console.WriteLine("不是");
            }

            //
            string[] m3 = { "张三", "李四", "王五", "寒梅" };
            string m4 = string.Join("|", m3);
            Console.WriteLine(m4);
        }
    }
}
