using System;
using Microsoft.Extensions.DependencyInjection;

namespace _02DI_can_ChuangRanXing {
    class Program {
        static void Main(string[] args){
            ServiceCollection sc = new ServiceCollection();
            sc.AddScoped<Controller>();
            sc.AddScoped<ILog, Log1>();
            sc.AddScoped<IStorage, Storage1>();
            sc.AddScoped<IConfig, Config1>();

            using (var sp = sc.BuildServiceProvider()){
                var c = sp.GetRequiredService<Controller>();//传染性体现。如果一个类（Controller）的对象是通过DI创建出来的，那么这个类的构造函数里面声明的所有服务类型的对象（ILog，IStorage，IConfig）都将被DI赋值
                c.Test();
            }
            Console.ReadKey();
        }
    }
    class Controller {
        private readonly ILog iLog;
        private readonly IStorage istoStorage;
        public Controller(ILog iLog, IStorage istoStorage){
            this.iLog = iLog;
            this.istoStorage = istoStorage;
        }
        public void Test(){
            iLog.Log("开始上传");
            istoStorage.Save("546464646464","1.txt");
            iLog.Log("上传完毕");
        }
    }
    interface ILog {
        public void Log(string mes);
    }
    class  Log1 : ILog {
        public void Log(string mes){
            Console.WriteLine($"日志：{mes}");
        }
    }
    interface IConfig {
        public string GetValue(string name);
    }
    class Config1 : IConfig {
        public string GetValue(string name){
            return "hello";
        }
    }
    interface IStorage {
        public void Save(string content, string name);
    }
    class Storage1 : IStorage {
        private readonly IConfig _config;
        public Storage1(IConfig config){
            this._config = config;
        }
        public void Save(string content, string name){
            string server = _config.GetValue("server");
            Console.WriteLine($"向服务器{server}的文件名为{name}上传{content}");
        }
    }
}