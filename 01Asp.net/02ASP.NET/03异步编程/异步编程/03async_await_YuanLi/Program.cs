using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _03async_await_YuanLi {
    class Program {
        //async await 原理
        static async Task Main(string[] args){
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            using (HttpClient httpClient = new HttpClient()){
                string html = await httpClient.GetStringAsync("http://www.baidu.com");
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(html);
            }
            string str = "Hello,kangkang!";
            string fileName = "D:\\AllTest\\3.txt";
            await File.WriteAllTextAsync(fileName, str);
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("写入成功");
            string getStr = await File.ReadAllTextAsync("D:\\AllTest\\3.txt");
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine(getStr);
        }
    }
}