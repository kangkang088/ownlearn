using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04async_change_thread {
    class Program {
        static async Task Main(string[] args){
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10000; i++){
                stringBuilder.Append("xxxxxxxxx");
            }
            await File.WriteAllTextAsync("D:\\AllTest\\4.txt", stringBuilder.ToString());//1
            
            
            
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId); //6
        }
    }
}