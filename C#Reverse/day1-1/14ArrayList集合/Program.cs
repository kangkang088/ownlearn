using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14ArrayList集合
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
            list.Add(1);
            list.Add(true);
            list.Add(3.47);
            list.Add("asfwq");
            list.Add('s');
            //对象默认打印对象所在的类的命名空间
            list.Add(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            Person person = new Person();
            list.Add(person);
            list.Add(list);
            for (int i = 0; i < list.Count; i++) 
            {
                if (list[i] is Person)
                {
                    ((Person)list[i]).SayHello();
                    continue;
                }
                if (list[i] is int[])
                {
                    //(int[])list[i]
                    for(int j = 0;j < ((int[])list[i]).Length;j++) { Console.WriteLine(((int[])list[i])[j]); }
                    continue;
                }
                Console.WriteLine(list[i]); 
            }

        }
    }
    public class Person
    {
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }
        public void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
}
