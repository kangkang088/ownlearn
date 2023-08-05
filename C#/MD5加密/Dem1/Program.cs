using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dem1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = GetMD5("123");
            Console.WriteLine(s);
            Console.ReadLine();
        }
        public static string GetMD5(string input)
        { 
            //创建MD5对象
            MD5 md5 = MD5.Create();
            //开始加密
            //将字符串转变成字节数组
            byte[] bytes = Encoding.UTF8.GetBytes(input);
            //返回一个加密好的字节数组
            byte[] bytes1 =  md5.ComputeHash(bytes);
            //将字节数组转变成字符串
            string st = "";
            for (int i = 0; i < bytes1.Length; i++)
            {
                //默认十进制，加个x会变成十六进制               
                st += bytes1[i].ToString("x");
            }
            return st;

        }
    }
}
