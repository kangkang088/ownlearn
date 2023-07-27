using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class StringDemo5
    {
        static void Main(string[] args)
        {
            //1.
            Console.WriteLine("请输入一个字符串");
            string s1 = Console.ReadLine();
            for (int i = s1.Length - 1; i >= 0; i--)
            {
                Console.Write(s1[i]);
            }
            Console.WriteLine();

            //2.
            string s2 = "hello c sharp";
            string[] strings = s2.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            s2 = string.Join(" ", strings);
            for (int i = 0; i < strings.Length / 2; i++)
            {
                string temp = strings[i];
                strings[i] = strings[strings.Length - 1 - i];
                strings[strings.Length - 1] = temp;
            }
            Console.WriteLine(s2);

            //3.
            string email = "1808@163.com";
            int forward = email.IndexOf("@");
            string info1 = email.Substring(0, forward);
            string info2 = email.Substring(forward + 1);
            Console.WriteLine("域名是{0}，用户名是{1}", info2, info1);

            Console.WriteLine();

            //4.
            string path = @"C:\Users\Administrator\Desktop\info.txt";
            string[] contents = File.ReadAllLines(path, Encoding.UTF8);
            for (int i = 0; i < contents.Length; i++)
            {
                string[] strNew = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine((strNew[0].Length > 10 ? strNew[0].Substring(0, 8) + "......" : strNew[0]) + '|' + '\t' + strNew[1]);
            }


            Console.WriteLine();

            //5.
            Console.WriteLine("请输入一句话，下面程序找出所有e的位置");
            string word = Console.ReadLine();
            string newword = word.Replace("e"," ");
            int number = 0;
            for (int i = 0; i < newword.Length; i++)
            {
                if (newword[i] == ' ')
                {
                    Console.WriteLine("第{0}个的下标是{1}",number+1,i);
                    number++;
                }
            }

        }

    }
}
