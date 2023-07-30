using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ArranList的长度问题
{
    internal class Demo1
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            //count 集合实际包含的元素数目
            //capacity  可以包含的元素数目

            ArrayList list1 = new ArrayList();
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                int rr = r.Next(0,10);
                while(list1.Contains(rr))
                {
                    rr = r.Next(0, 10);
                }
                    list1.Add(rr);
            }
            for (int i = 0; i < list1.Count; i++)
            {
                Console.WriteLine(list1[i]);
            }



        }
    }
}
