using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ISwim swim = new MuDuck();
            swim.Swim();
        }
    }
    public class RealDuck:ISwim
    {
        public void Swim()
        {
            Console.WriteLine("真的鸭子会游泳");
        }
        
    }
    public class MuDuck:RealDuck,ISwim
    {
         void ISwim.Swim()
        {
            Console.WriteLine("木头鸭子不会游泳");
        }
    }
    public class EraseDuck:RealDuck,ISwim
    {
        public void Swim()
        {
            Console.WriteLine("橡皮鸭子会游泳");
        }
    }
    public interface ISwim
    {
        void Swim();
    }
}
