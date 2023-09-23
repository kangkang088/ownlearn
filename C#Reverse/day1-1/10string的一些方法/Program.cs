using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10string的一些方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //string str = "国家关键人物老魏";
            //if (str.Contains("老魏"))
            //{
            //    str = str.Replace("老魏", "**");
            //    Console.WriteLine(str);
            //}

            //substring
            //string str = "今天天气好晴朗，处处好风光";
            //str = str.Substring(0,str.Length - 1);//截取的长度
            //Console.WriteLine(str);

            //string str = "今天天气好晴朗，处处好风光";
            //if (str.StartsWith("今天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //if (str.EndsWith("今天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}

            //string str = "今天天气好晴朗，处处天好风光";
            //int index = str.IndexOf('天', 2);//从某处开始，包括该处
            //int index_s = str.LastIndexOf('天');
            //Console.WriteLine(index_s);

            //string str = @"c:w/we/ta/wetgareq/qweqwdra/daweqqq/苍老师.avi";
            //int lastIndex = str.LastIndexOf('/');
            //Console.WriteLine(lastIndex);
            //str = str.Substring(lastIndex + 1);
            //Console.WriteLine(str);

            //string str1 = "               hahahhahahah    ";
            //str1 = str1.Trim();
            //Console.WriteLine(str1);
            //string str2 = "               hahahhahahah    ";
            //str2 = str2.TrimStart();
            //Console.WriteLine(str2);
            //string str3 = "               hahahhahahah    ";
            //str3 = str3.TrimEnd();
            //Console.WriteLine(str3);

            //string str = null;
            //if(string.IsNullOrEmpty(str)) { Console.WriteLine("是"); }else { Console.WriteLine("不是"); }

            string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            string str = null;
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (i <= names.Length - 2)
            //    {
            //        str += names[i] + "|";
            //    }
            //    else { str += names[i]; }
            //}
            //Console.WriteLine(str);

            str = string.Join("|", names);
            Console.WriteLine(str);


        }
    }
}
