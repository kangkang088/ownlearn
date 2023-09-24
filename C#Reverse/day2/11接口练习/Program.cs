using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11接口练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Flyable flyable1 = new ZSPlane();
            flyable1.Fly();
            Flyable flyabel2 = new PQPlane();
            flyabel2.Fly();
        }
    }
    public class ZSPlane : Flyable
    {
        public void Fly()
        {
            Console.WriteLine("直升飞机飞");
        }
    }
    public class PQPlane : Flyable
    {
        public void Fly()
        {
            Console.WriteLine("喷气飞机飞");
        }
    }
    public class MQBird : Flyable
    {
        public void Fly()
        {
            Console.WriteLine("麻雀飞");
        }
    }
    public class QEBird : Flyable
    {
        public void Fly()
        {
            Console.WriteLine("企鹅不会飞");
        }
    }
    public interface Flyable 
    {
        void Fly();
    }
}
