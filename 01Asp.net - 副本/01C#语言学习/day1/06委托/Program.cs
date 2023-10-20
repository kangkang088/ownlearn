using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06委托
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Reporter();//直接调用


            //Action 是一个委托（程序给我们封装好的委托，我们直接用），里面可以装方法。
            Action action = new Action(calculator.Reporter);
            action.Invoke();//间接调用。使用委托
            action();//简便写法，为了模仿函数指针


            Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);

            int x = 100;
            int y = 200;
            int z = 0;

            z = func1.Invoke(x, y);//间接调用，使用委托
            Console.WriteLine(z);
            z = func2.Invoke(x, y);//间接调用，使用委托
            Console.WriteLine(z);

            z = func1(x, y);//间接调用，使用委托，模仿函数写法
            Console.WriteLine(z);
            z = func2(x, y);//间接调用，使用委托，模仿函数写法
            Console.WriteLine(z);
        }
    }
    class Calculator
    {
        public void Reporter()
        {
            Console.WriteLine("I have three methods");
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
    }
}
