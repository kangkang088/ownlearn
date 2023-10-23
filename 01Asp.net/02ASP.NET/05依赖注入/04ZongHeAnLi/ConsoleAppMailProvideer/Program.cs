using System;
using ConfigService;
using LogService;
using MailService;
using Microsoft.Extensions.DependencyInjection;
namespace _04ZongHeAnLi {
    class Program {
        static void Main(string[] args){
            ServiceCollection sc = new ServiceCollection();
            sc.AddScoped<IConfigService, EnvirVarConfigService>();
            sc.AddScoped<IMailService, MailService.MailService>();
            sc.AddScoped<ILogProvider, LogService.ConsoleLogProvider>();
            sc.AddScoped(typeof(IConfigService),s=>new iniFileConfigService{FilePath = "mail.ini"});

            using (var sp = sc.BuildServiceProvider()){
                var mailService = sp.GetRequiredService<IMailService>();
                mailService.Send("Hello","kangkang088@.com","懂哥你好");
            }
        }
    }
}