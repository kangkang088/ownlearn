using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08接口特征
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
    public interface IFlyable
    {
        //1.可以有返回值，没有任何访问修饰符，默认为public
        void Fly();
        string Test();
        //2.接口中的成员不允许有方法体
        //string show() { Console.WriteLine(); }

        //3.不允许有字段,把存数据的作用留给类吧
        //string _name;

        //4.可以有属性,但是看第二条，不能有方法体
        /// <summary>
        /// 自动属性 编译时自动生成字段，要想限定，只能通过构造函数咯
        /// </summary>
        string Name { get; set; }

    }
}
