using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntArray intArray = new IntArray();
            intArray[0] = 15;
            int a = intArray[0];
            Console.WriteLine(a);
        }
    }
    class IntArray
    {
        private int[] arr = new int[10];
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index <= this.arr.Length - 1)
                    return this.arr[index];
                return -1;
            }
            set
            {
                if (index >= 0 && index <= this.arr.Length - 1)
                    this.arr[index] = value;
            }
        }
    }
}
