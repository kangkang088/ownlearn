using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11结构
{
    enum Gender
    { 
        男,
        女
    }
    struct Person
    {
        //加public，叫字段，字段区别于变量，程序运行时可以存储多个值
        public string _name;
        public int _age;
        public Gender _gender;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Person p1;
            p1._name = "A";
            p1._age = 20;
            p1._gender = Gender.男;
        }
    }
}
