using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace _08CancellationToken {
    class Program {
        static async Task Main(string[] args){
            await DownloadAsync1("http://www.baidu.com", 100);
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            cancellationTokenSource.CancelAfter(5000);
            await DownloadAsync2("http://www.baidu.com", 100, cancellationTokenSource.Token);
            await DownloadAsync3("http://www.baidu.com", 100, cancellationTokenSource.Token);
        }
        //download 100 without other needs
        static async Task DownloadAsync1(string url, int n){
            using (HttpClient httpClient = new HttpClient()){
                for (int i = 0; i < n; i++){
                    string html = await httpClient.GetStringAsync(url);
                    Console.WriteLine($"{DateTime.Now}:{html}");
                }
            }
        }
        //when times over 5s ,the async method end!
        static async Task DownloadAsync2(string url, int n, CancellationToken cancellationToken){
            using (HttpClient httpClient = new HttpClient()){
                for (int i = 0; i < n; i++){
                    string html = await httpClient.GetStringAsync(url);
                    Console.WriteLine($"{DateTime.Now}:{html}");
                    //手动响应取消
                    // if (cancellationToken.IsCancellationRequested){
                    //     Console.WriteLine("请求被取消");
                    //     break;
                    // }
                    cancellationToken.ThrowIfCancellationRequested(); //exception  到时间取消了就抛异常
                }
            }
        }
        static async Task DownloadAsync3(string url, int n, CancellationToken cancellationToken){
            using (HttpClient httpClient = new HttpClient()){
                for (int i = 0; i < n; i++){
                    //我们不处理CancellationToken参数，调用GetAsync让它去处理，超时了就抛异常
                    var resp = await httpClient.GetAsync(url, cancellationToken);
                    string html = await resp.Content.ReadAsStringAsync();//超时就会抛异常
                    Console.WriteLine($"{DateTime.Now}:{html}");
                    
                    
                    //手动响应取消
                    // if (cancellationToken.IsCancellationRequested){
                    //     Console.WriteLine("请求被取消");
                    //     break;
                    // }

                    //cancellationToken.ThrowIfCancellationRequested();//exception  取消了就抛异常
                }
            }
        }
    }
}