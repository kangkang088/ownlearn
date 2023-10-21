using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _09asp.net_core_cancel.Models;

namespace _09asp.net_core_cancel.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger){
            _logger = logger;
        }
        public async Task<IActionResult> Index(CancellationToken cancellationToken){
            await DownloadAsync2("http://www.baidu.com", 20,cancellationToken);
            return View();
        }
        static async Task DownloadAsync2(string url, int n, CancellationToken cancellationToken){
            using (HttpClient httpClient = new HttpClient()){
                for (int i = 0; i < n; i++){
                    var responseMessage = await httpClient.GetAsync(url,cancellationToken);
                    string html = await responseMessage.Content.ReadAsStringAsync();
                    Console.WriteLine($"{DateTime.Now}:{html}");
                    Debug.WriteLine(html);
                }
            }
        } 
        public IActionResult Privacy(){
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(){
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}