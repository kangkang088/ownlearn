using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //操作文件
            //剪切，创建，移除
            //File.Create("C:\\Users\\Administrator\\Desktop\\chaungjian.txt");
            //Console.WriteLine("创建成功");
            //File.Delete("C:\\Users\\Administrator\\Desktop\\chaungjian.txt");
            //Console.WriteLine("删除成功");

            //复制
            //File.Copy("C:\\Users\\Administrator\\Desktop\\111.txt", "C:\\Users\\Administrator\\Desktop\\chuangjian.txt");
            //Console.WriteLine("复制成功");

            //剪切
            //File.Move("C:\\Users\\Administrator\\Desktop\\222.txt", "C:\\Users\\Administrator\\Desktop\\new222.txt");
            //Console.WriteLine("剪切成功");

            //读取数据

            //byte[] bytes = File.ReadAllBytes("C:\\Users\\Administrator\\Desktop\\111.txt");
            //string str = Encoding.Default.GetString(bytes,0,bytes.Length);
            //Console.WriteLine(str);

            //string[] str = File.ReadAllLines("C:\\Users\\Administrator\\Desktop\\111.txt",Encoding.Default);
            //foreach (string str2 in str) { Console.WriteLine(str2); }

            //string str = File.ReadAllText("C:\\Users\\Administrator\\Desktop\\111.txt",Encoding.Default);
            //Console.WriteLine(str);

            //--------------------------------------------------------------------------------------

            //写入数据


            //string str = "覆盖了吗？";
            //byte[] bytes = Encoding.UTF8.GetBytes(str);
            //File.WriteAllBytes("C:\\Users\\Administrator\\Desktop\\zijiexieru.txt", bytes);

            //File.WriteAllLines("C:\\Users\\Administrator\\Desktop\\hangxieru.txt", new string[] { "张三", "李四", "王五" });


            File.WriteAllText("C:\\Users\\Administrator\\Desktop\\wenbenxieru.txt", "会覆盖");
            File.AppendAllText("C:\\Users\\Administrator\\Desktop\\wenbenxieru.txt", "不会覆盖");



        }
    }
}
