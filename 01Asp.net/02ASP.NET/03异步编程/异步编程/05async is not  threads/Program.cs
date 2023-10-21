using System;
using System.Threading;
using System.Threading.Tasks;

namespace _05async_is_not__threads {
    //async method is not equals to threads
    class Program {
        static async Task Main(string[] args){
            Console.WriteLine("before:" + Thread.CurrentThread.ManagedThreadId);
            double returnValue = await CalcAsync(5000);
            Console.WriteLine(returnValue);
            Console.WriteLine("after:" + Thread.CurrentThread.ManagedThreadId);
        }
        public static Task<double> CalcAsync(int n){
            // Console.WriteLine("CalcAsync," + Thread.CurrentThread.ManagedThreadId);
            // double result = 0;
            // Random r = new Random();
            // for (int i = 0; i < n*n; i++){
            //     result += r.NextDouble();
            // }
            // return result;
            return Task.Run(() => {
                Console.WriteLine("CalcAsync," + Thread.CurrentThread.ManagedThreadId);
                double result = 0;
                Random r = new Random();
                for (int i = 0; i < n * n; i++){
                    result += r.NextDouble();
                }
                return Task.FromResult(result);
            });
        }
    }
}