using System;
using ConfigService;
using LogService;

namespace MailService {
    public class MailService : IMailService {
        private readonly ILogProvider log;
        private readonly IConfigService config;
        public MailService(ILogProvider log, IConfigService config){
            this.log = log;
            this.config = config;
        }
        public void Send(string title, string to, string body){
            log.LogInfo("准备发送邮件");
            string server = config.GetValue("server");
            string username = config.GetValue("username");
            string password = config.GetValue("password");
            Console.WriteLine($"邮件服务器地址{server}，{username}，{password}");
            Console.WriteLine($"发邮件了！！！{title},{to}");
            log.LogInfo("邮件发送完成");
        }
    }
}