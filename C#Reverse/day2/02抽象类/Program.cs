using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02抽象类
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
        }
    }
    public abstract class Animals
    {
        public abstract void Bark();
        
            //怎么叫不知道，是喵喵叫还是汪汪叫？
            //不知道父类方法怎么实现时，可以将父类写成抽象类，方法写成抽象方法
        
    }
    public class Dog:Animals
    {
        public override void Bark()
        {
            Console.WriteLine("汪汪叫");
        }
    }
    public class Cat : Animals
    {
        public override void Bark()
        {
            Console.WriteLine("喵喵叫");
        }
    }
}
