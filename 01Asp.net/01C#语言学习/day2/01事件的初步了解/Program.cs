using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;

namespace _01事件的初步了解
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();//事件拥有者
            timer.Interval = 1000;
            Boy boy = new Boy();//事件响应者
            Girl girl = new Girl();
            //    事件  事件订阅      事件处理器
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();
        }
    }

    class Boy
    {
        //事件处理器
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }

    class Girl
    {
        //事件处理器
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
