using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _ArrayList集合
{
    internal class ArrayListDemo1
    {
        static void Main(string[] args)
        {
            //创建集合对象
            ArrayList list = new ArrayList();
            list.Add(1);
            list.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
