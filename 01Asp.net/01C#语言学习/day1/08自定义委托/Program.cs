using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08自定义委托
{
    //              目标方法的返回值    目标方法的参数列表
    public delegate double Calc(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Calc calc1 = new Calc(calculator.Add);           
            Calc calc2 = new Calc(calculator.Sub);
            Calc calc3 = new Calc(calculator.Mul);
            Calc calc4 = new Calc(calculator.Div);

            double a = 100;
            double b = 200;
            double c = 0;
            c = calc1(a, b);
            Console.WriteLine(c);
            c = calc2(a, b);
            Console.WriteLine(c);
            c = calc3(a, b);
            Console.WriteLine(c);
            c = calc4(a, b);
            Console.WriteLine(c);

        }
    }
    class Calculator
    {
        public double Add(double x, double y)
        { 
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Mul(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            return x / y;
        }
    }
}
