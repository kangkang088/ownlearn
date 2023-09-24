using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01多态
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Chinese chinese1 = new Chinese("韩梅梅");
            Chinese chinese2 = new Chinese("李雷");
            Janapnese janapnese1 = new Janapnese("树下子");
            Janapnese janapnese2 = new Janapnese("松上树");
            Korea korea1 = new Korea("全智贤");
            Korea korea2 = new Korea("金枝勇");
            American american1 = new American("科比布莱恩特");
            American american2 = new American("奥尼尔");
            Person[] person = { chinese1, chinese2, janapnese1, janapnese2, korea1, korea2, american1, american2 };
            for (int i = 0; i < person.Length; i++) { person[i].SayHello(); }

        }
    }
    public class Person
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public Person(string name)
        { this.Name = name; }
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Chinese : Person
    {
        public Chinese(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine("我是中国人，我叫{0}", this.Name);
        }
    }
    public class Janapnese : Person
    {
        public Janapnese(string name) : base(name) { }
        public override void SayHello()
        {
            Console.WriteLine("我是脚盆人，我叫{0}", this.Name);
        }
    }
    public class Korea : Person
    {
        public Korea(string name) : base(name) { }
        public override void SayHello() { Console.WriteLine("我是棒子人，我叫{}", this.Name); }
    }
    public class American : Person
    {
        public American(string name) : base(name) { }
        public override void SayHello() { Console.WriteLine("我是美国人，我叫{0}", this.Name); }
    }
}
