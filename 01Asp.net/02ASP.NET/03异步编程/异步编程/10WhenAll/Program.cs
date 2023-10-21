using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace _10WhenAll {
    class Program {
        static async Task Main(string[] args){
            // Task<string> t1 = File.ReadAllTextAsync("D:\\AllTest\\1.txt");
            // Task<string> t2 = File.ReadAllTextAsync("D:\\AllTest\\2.txt");
            // Task<string> t3 = File.ReadAllTextAsync("D:\\AllTest\\3.txt");
            // string[] strings = await Task.WhenAll(t1, t2, t3);//after t1 t2 t3 both done,strings be gotten!
            // string s1 = strings[0];
            // string s2 = strings[1];
            // string s3 = strings[2];
            // Console.WriteLine(s1);
            // Console.WriteLine(s2);
            // Console.WriteLine(s3);

            string[] files = Directory.GetFiles("D:\\AllTest");
            Task<int>[] countTasks = new Task<int>[files.Length];
            for (int i = 0; i < files.Length; i++){
                string filename = files[i];
                countTasks[i] = ReadCharCount(filename);
            }
            int[] counts = await Task.WhenAll(countTasks);
            Console.WriteLine(counts.Sum());
        }
        static async Task<int> ReadCharCount(string filename){
            string s = await File.ReadAllTextAsync(filename);
            return s.Length;
        }
    }
}