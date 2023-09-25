using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22进程类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.获取当前程序中所有正在运行的进程
            //Process[] pros = Process.GetProcesses();
            //foreach (var item in pros)
            //{
            //    //item.Kill();
            //    Console.WriteLine(item);
            //}

            //2.通过进程打开一些应用程序
            //Process.Start("calc");
            //Process.Start("mspaint");
            //Process.Start("notepad");
            //Process.Start("iexplore","http://www.baidu.com");

            //3.打开电脑上的指定文件
            ProcessStartInfo processStartInfo = new ProcessStartInfo("C:\\Users\\Administrator\\Desktop\\111.txt");
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();

        }
    }
}
