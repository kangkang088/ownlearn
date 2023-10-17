using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2 {
    //二。实现自己的Where方法
    class Program {
        static void Main(string[] args){
            int[] arr = { 1, 564, 49, 8, 7, 894, 487, 5, 4541 };
            IEnumerable<int> ints = MyWhere.MyWhere_s(arr, i => i % 2 == 0);
            foreach (int VARIABLE in ints){
                Console.WriteLine(VARIABLE);
            }
        }
    }
}
static class MyWhere {
    public static IEnumerable<T> MyWhere_s<T>(this IEnumerable<T> data, Func<T, bool> func){
        List<T> list = new List<T>();
        foreach (T item in data){
            //判断遍历到的数据是否满足条件
            if (func.Invoke(item)){
                list.Add(item);
            }
        }
        return list;
    }
}