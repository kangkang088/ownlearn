using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 多态;

namespace 多态Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] per = new Person[6];
            Chinese chinese = new Chinese("韩梅梅");
            Chinese chinese1 = new Chinese("李磊");
            Japanese japanese = new Japanese("树下君");
            Japanese japanese1 = new Japanese("小樱花");
            Korea korea = new Korea("金秀贤");
            Korea korea1 = new Korea("金贤秀");
            American american = new American("科比布莱恩特");
            American american1 = new American("奥尼尔");
            Person[] p = new Person[] { chinese, chinese1, japanese, japanese1, korea, korea1, american, american1 };
            //不多态

            //for (int i = 0; i < p.Length; i++)
            //{
            //    if (p[i] is Chinese)
            //    {
            //        ((Chinese)p[i]).SayHello();
            //    }
            //    else if (p[i] is Japanese) { ((Japanese)p[i]).SayHello();}
            //    else if (p[i] is Korea) { ((Korea)p[i]).SayHello(); }
            //    else if(p[i] is American) { ((American)p[i]).SayHello(); }

            //}

            //多态
            //1.虚方法
            //父类方法前加virtual
            //子类方法public后面加override
            for (int i = 0; i < p.Length; i++)
            {
                p[i].SayHello();
            }
 

        }
    }
}
