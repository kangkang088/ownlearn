using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07多态
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.虚方法
            //2.抽象类

            Console.WriteLine("请输入第一个数字");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入一个运算符");
            string oper = Console.ReadLine();
            CalFather cal = GetCal(oper, num1, num2);
            double result = cal.Result();
            Console.WriteLine(result);
        }
        public static CalFather GetCal(string oper, double num1, double num2)
        {
            CalFather cal = null;
            switch (oper)
            {
                case "+":
                    cal = new Add(num1, num2); break;
                case "-": cal = new Sub(num1, num2); break;
                case "*": cal = new Cheng(num1, num2); break;
                case "/": cal = new Chu(num1, num2); break;
            }
            return cal;
        }
    }
    public abstract class CalFather
    {
        public double NumberOne { get; set; }
        public double NumberTwo { get; set; }
        public CalFather(double num1, double num2)
        {
            this.NumberOne = num1;
            this.NumberTwo = num2;
        }
        public abstract double Result();
    }
    public class Add : CalFather
    {
        public Add(double num1, double num2) : base(num1, num2) { }
        public override double Result()
        {

            return this.NumberOne + this.NumberTwo;
        }
    }
    public class Sub : CalFather
    {
        public Sub(double num1, double num2) : base(num1, num2) { }
        public override double Result()
        {

            return this.NumberOne - this.NumberTwo;
        }
    }
    public class Cheng : CalFather
    {
        public Cheng(double num1, double num2) : base(num1, num2) { }
        public override double Result()
        {

            return this.NumberOne * this.NumberTwo;
        }
    }
    public class Chu : CalFather
    {
        public Chu(double num1, double num2) : base(num1, num2) { }
        public override double Result()
        {

            return this.NumberOne / this.NumberTwo;
        }
    }


}
