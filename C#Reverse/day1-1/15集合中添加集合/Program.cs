using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15集合中添加集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            ArrayList list = new ArrayList();
            list.Add(true);
            list.Add(1.25m);
            list.Add("张三");
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            list.AddRange(list);
            //list.Remove(true);//删除单个元素
            //list.RemoveAt(0);//根据下标删除
            //list.RemoveRange(0, 3); //删除一定数量的元素 
            //list.Reverse();//反转
            //list.Insert(1, "插入的");//指定位置插入元素
            //list.InsertRange(0, new int[] { 1, 2, 3 });//指定位置插入集合
            bool b = list.Contains(true);
            Console.WriteLine(b);
            for (int i = 0; i < list.Count; i++) { Console.WriteLine(list[i]); }
            Console.ReadKey();


            list.Clear();
        }
    }
}
