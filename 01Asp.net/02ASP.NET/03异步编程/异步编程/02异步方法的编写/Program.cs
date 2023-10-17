using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace _02异步方法的编写
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            int length = await DownloadHtmlAsync("https://www.youzack.com", "D:\\AllTest\\2.txt");
            await Console.Out.WriteLineAsync("ok");
            await Console.Out.WriteLineAsync(length.ToString());
        }
        static async Task<int> DownloadHtmlAsync(string url, string fileName)
        {
            using (HttpClient client = new HttpClient())
            {
                string html = await client.GetStringAsync(url);
                await File.WriteAllTextAsync(fileName, html);
                return html.Length;
            }
            
        }
    }
}
