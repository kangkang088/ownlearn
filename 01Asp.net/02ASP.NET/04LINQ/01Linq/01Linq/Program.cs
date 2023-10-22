using System;
using System.Collections.Generic;
using System.Linq;

namespace _01Linq {
    class Program {
        static void Main(string[] args){
            int[] arr = new[] { 1, 5, 8, 9, 45, 16, 897, 64, 8978, 464, 16854, 35131 };
            IEnumerable<int> result = MyWhere1(arr,i => i > 10);
            foreach (var item in result){
                Console.WriteLine(item);
            }
        }
        static IEnumerable<int> MyWhere1(IEnumerable<int> items, Func<int, bool> f){
            foreach (int item in items){
                if (f(item) == true){
                    yield return item;
                }
            }
        }
    }
}