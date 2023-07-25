using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public enum myColor
    {
        红,
        绿,
        蓝
    }
    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }
    public enum Gender
    { 
        男,
        女
    }
    public struct Person
    { 
        public string _name;
        public int _age;
        public Gender _gender;
    }
    internal class StructDemo2
    {
        static void Main(string[] args)
        {
            MyColor mc;
            mc._red = 255;
            mc._green = 0;
            mc._blue = 0;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Person zsPerson;
            zsPerson._name = "张三";
            zsPerson._age = 18;
            zsPerson._gender = Gender.男;
            Person xlPerson;
            xlPerson._name = "小兰";
            xlPerson._age = 20;
            xlPerson._gender = Gender.女;

            Console.WriteLine("我叫{0}，今年{1}岁，性别{2}",zsPerson._name,zsPerson._age,zsPerson._gender);
            Console.WriteLine("我叫{0}，今年{1}岁，性别{2}",xlPerson._name,xlPerson._age,xlPerson._gender);
            Console.ReadKey();
        }
    }
}
