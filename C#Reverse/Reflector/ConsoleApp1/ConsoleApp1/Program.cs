using System;

namespace ConsoleApp1 {
    //一。获取Type对象并动态创建对象
    class Program {
        static void Main(string[] args){
            //下面N中获取对象的Type对象的方法，最终获得的都是同一个Type对象
            Peron p1 = new Peron();
            Peron p2 = new Peron();
            Peron p3 = new Peron();
            Type type1 = p1.GetType();
            Type type2 = p2.GetType();
            Type type3 = typeof(Peron);
            Type type = Type.GetType("ConsoleApp1.Peron");
            Console.WriteLine(type1);
            Console.WriteLine(type2);
            Console.WriteLine(type3);
            Console.WriteLine(type);
            Console.WriteLine(object.ReferenceEquals(type1,type2));

            object o = Activator.CreateInstance(type1);//动态创建type1指向的对象，类必须有public且无参的构造函数
            Console.WriteLine(o);
        }
    }
    class Peron {
        public override string ToString(){
            return "我是Person";
        }
    }
}