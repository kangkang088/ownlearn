using ConfigReader;
using ConfigService;
using MailService;
using Microsoft.Extensions.DependencyInjection;
namespace _04ZongHeAnLi {
    class Program {
        static void Main(string[] args) {
            ServiceCollection sc = new ServiceCollection();
            sc.AddScoped<IConfigService, EnvirVarConfigService>();
            
            //sc.AddScoped<ILogProvider, LogService.ConsoleLogProvider>();

            //sc.AddScoped(typeof(IConfigService), s => new iniFileConfigService { FilePath = "mail.ini" });

            //sc.AddConsoleLog();//通过扩展方法，直接。出来，不用知道对象的具体类型了。
            sc.AddIniFileConfig("mail.ini");
            sc.AddConsoleLog();
            //sc.AddScoped<IConfigReader, LayeredConfigReader>();
            sc.AddLayeredConfig();//为最后一个读取的配置文件的值
            sc.AddScoped<IMailService, MailService.MailService>();
            

            using (var sp = sc.BuildServiceProvider()) {
                var mailService = sp.GetRequiredService<IMailService>();
                mailService.Send("Hello", "kangkang088@.com", "懂哥你好");
            }
        }
    }
}