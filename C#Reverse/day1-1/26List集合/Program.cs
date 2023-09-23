using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26List集合
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //当arraylist集合的元素类型一样时，往往用list泛型集合代替，因为arraylist集合的元素返回值是object类型的，使用时要强制转换成对应的元素类型，泛型集合直接明确这一统一的类型
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(4);
            arrayList.Add(5);
            arrayList.Add(6);
            arrayList.Add(7);
            arrayList.Add(8);
            arrayList.Add(9);
            arrayList.Add(10);
            int sum = 0; int max = (int)arrayList[0];
            int min = (int)arrayList[0];
            //一直在进行数据类型转换
            for (int i = 1; i < arrayList.Count; i++)
            {
                sum += (int)arrayList[i];
                if ((int)arrayList[i] > max)
                {
                    max = (int)arrayList[i];
                }
                if ((int)arrayList[i] < min)
                { min = (int)arrayList[i]; }
            }
            Console.WriteLine("最大值{0}，最小值{1}，总和{2}", max, min, sum);

            //用List泛型集合来解决
            List<int> list = new List<int>();
            for (int i = 1; i < 11; i++)
            {
                list.Add(i);
            }
            list.AddRange(new int[] { 25, 26, 27 });
            list.Insert(0, 34);
            list.InsertRange(0, new int[] { 55, 66 });
            //list.Clear();
            list.Remove(55);
            list.RemoveAt(0);
            list.RemoveRange(0, 1);
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            
        }
    }
}
