using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            Duck[] duck = { new EraseDuck("橡皮鸭子"), new MuDuck("母鸭子"), new Realduck("真的鸭子") };
            for (int i = 0; i < duck.Length; i++)
            {
                duck[i].Show();
            }
            
        }
    }
}
