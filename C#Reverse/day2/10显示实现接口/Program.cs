using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10显示实现接口
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //3.既然方法同名，那我们如何分开调用这两个方法呢？
            //答案是利用多态
            //3.1调用接口中的
            IEatable eatable = new MQBird();
            //这里好像和多态有些违背，但注意这不是虚方法实现的多态，而是接口实现的多态。
            eatable.Eat();
            //3.2调用类中的
            MQBird mQBird = new MQBird();
            mQBird.Eat();
        }
    }
    public class MQBird : IEatable
    {
        //1.这个方法到底是类的还是接口的？既然没报错，就说明这个是接口的。那我们如何得到一个这个类的同名方法呢？
        //答案就是显示实现接口
        public void Eat() { Console.WriteLine("麻雀会吃"); }
        //2.加上下面这行代码，会使上面的方法由原本的接口方法变为类自己的方法。
        void IEatable.Eat() { Console.WriteLine("接口中的吃"); }
    }
    public class QQBird : IEatable
    {
        public void Eat() { Console.WriteLine("企鹅也会吃"); }
    }
    public interface IEatable { void Eat(); }
}
