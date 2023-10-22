using System;
using Microsoft.Extensions.DependencyInjection;

namespace _01DI {
    class Program {
        static void Main(string[] args){
            //服务注册-普通方式
            ITestService testService = new TestServiceImpl();
            testService.Name = "tom";
            testService.SayHi();
            //依赖注入
            ServiceCollection serviceCollection = new ServiceCollection();

            //serviceCollection.AddScoped<TestServiceImpl>();
            serviceCollection.AddScoped(typeof(ITestService), typeof(TestServiceImpl));
            using (ServiceProvider sp = serviceCollection.BuildServiceProvider()){
                using (IServiceScope sc = sp.CreateScope()){
                    ITestService test2 = sc.ServiceProvider.GetService<ITestService>();
                    test2.Name = "tom";
                    test2.SayHi();
                    ITestService test3 = sp.GetService<ITestService>();
                    Console.WriteLine(ReferenceEquals(test2, test3));
                }
            }
        }
    }
    public interface ITestService {
        public string Name { get; set; }
        public void SayHi();
    }
    public class TestServiceImpl : ITestService {
        public string Name { get; set; }
        public void SayHi(){
            Console.WriteLine($"Hi, I'm {Name}");
        }
    }
    public class TestServiceImpl2 : ITestService {
        public string Name { get; set; }
        public void SayHi(){
            Console.WriteLine($"你好，我是{Name}");
        }
    }
}