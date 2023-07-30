using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _dictionary键值对集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> d = new Dictionary<int,string>();
            d.Add(1, "张三");
            d.Add(2,"李四");
            d.Add(3,"王五");

            //foreach (var item in d.Keys)
            //{
            //    Console.WriteLine(d[item]);
            //}

            //kv代表键和值
            foreach (KeyValuePair<int,string> kv in d)
            {
                Console.WriteLine("{0},{1}",kv.Key,kv.Value);
            }

            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            List<int> listJiShu = new List<int>();
            List<int> listOuShu = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    listJiShu.Add(arr[i]);
                }
                else
                {
                    listOuShu.Add(arr[i]);
                }
            }
            listOuShu.AddRange(listJiShu);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("请输入一个字符串");
            string input = Console.ReadLine();
            char[] chars = new char[input.Length];
            int i1 = 0;
            foreach (char c in input) 
            {
                chars[i1] = c; i1++;
            }
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            //统计Welcome to china 中每个字符出现的次数，不考虑大小写
            string str1 = "Welcome to china";
            str1 = str1.ToLower();
            //字符作为键，出现的次数作为值
            Dictionary<char,int> dic = new Dictionary<char,int>();
            
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] == ' ')
                {
                    continue;
                }
                if (dic.ContainsKey(str1[i]))
                {
                    dic[str1[i]]++;
                }
                else
                {
                    dic[str1[i]] = 1; 
                }
            }
            foreach (KeyValuePair<char,int> item in dic)
            {
                Console.WriteLine("{0}出现了{1}次",item.Key,item.Value);
            }
            
        }
    }
}
