using System;
using System.Diagnostics;

namespace _01Process {
    internal class Program {
        public static void Main(string[] args){
            Process[] pros = Process.GetProcesses();
            foreach (Process process in pros){
                Console.WriteLine(process);
                
            }
            //杀死进程
            //pros[0].Kill();//慎用
            
            //打开一些应用程序
            Process.Start("calc");
            
            //打开网页
            Process.Start("http://www.baidu.com");//默认浏览器
            Process.Start("iexplore","http://www.baidu.com");//指定浏览器
            
            //打开指定文件
            Process process1 = new Process();
            process1.StartInfo = new ProcessStartInfo("C:\\Users\\Administrator\\Desktop\\1808.txt");
            process1.Start();
        }
    }
}