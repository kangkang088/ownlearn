using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02异常
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Calculator calculator = new Calculator();

            try { sum = calculator.Add("1000000000000000000000000000", "100"); }
            catch(OverflowException ex) { Console.WriteLine(ex.Message); }
            Console.WriteLine(sum);
            

        }
    }
    public class Calculator
    {
        public int Add(string arg1, string arg2)
        {
            int a = 0;
            int b = 0;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            catch (ArgumentException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (FormatException fs)
            {
                Console.WriteLine(fs.Message);
            }
            catch (OverflowException of)
            {
                throw of;
            }
            return a + b;
        }
    }
}
