using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _01async_await的基本使用
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string fileName = "D:\\AllTest\\1.txt";
            //File.WriteAllText(fileName, "hello");
            //string s = File.ReadAllText(fileName);
            //Console.WriteLine(s);

            //异步
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 100000; i++) 
            {
                stringBuilder.Append("hello");
            }
            await File.WriteAllTextAsync(fileName, stringBuilder.ToString());
            string s1 = await File.ReadAllTextAsync(fileName);

            await Console.Out.WriteLineAsync(s1);

        }
    }
}
