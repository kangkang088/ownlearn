using System;
using System.IO;
using System.Threading.Tasks;

namespace _06async_method_has_not_async {
    class Program {
        //为什么有的异步方法没有async标记
        static async Task Main(string[] args){
            string s = await ReadAsync(2);
            Console.WriteLine(s);
        }
        static Task<string> ReadAsync(int num){
            if (num == 0){
                return File.ReadAllTextAsync("D:\\AllTest\\1.txt");
            }
            else if (num == 1){
                return File.ReadAllTextAsync("D:\\AllTest\\2.txt");
            }
            else if (num == 2){
                return File.ReadAllTextAsync("D:\\AllTest\\3.txt");
            }
            else{
                throw new ArgumentException();
            }
        }
    }
}