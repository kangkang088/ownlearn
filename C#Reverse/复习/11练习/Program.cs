
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] str = File.ReadAllLines("C:\\Users\\Administrator\\Desktop\\工资.txt");
            for (int i = 0; i < str.Length; i++)
            {
                string[] steNew = str[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                str[i] = steNew[0] + Convert.ToInt32(steNew[1]) * 2;
            }
            File.WriteAllLines("C:\\Users\\Administrator\\Desktop\\工资.txt", str);
        }
    }
}
