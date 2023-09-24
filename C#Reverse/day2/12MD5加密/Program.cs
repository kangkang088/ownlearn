using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _12MD5加密
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }   
            string str = GetMD5("123");
            Console.WriteLine(str);

        }
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            //开始加密
            byte[] bytes = Encoding.Default.GetBytes(str);
            //返回加密好的字节数组
            byte[] b = md5.ComputeHash(bytes);
            string s = "";
            for (int i = 0; i < b.Length; i++) 
            {
                s += b[i].ToString("x");
            }
            return s;

        }
    }
}
