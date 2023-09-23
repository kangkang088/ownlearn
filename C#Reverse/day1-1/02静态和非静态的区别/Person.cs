using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02静态和非静态的区别
{
    //静态类中只能有静态成员，静态类不能被实例化
    internal class Person
    {
        private static string _name;
        public string Name { get { return Person._name; } set { Person._name = value; } }
        private static char _gender;
        public char Gender { get { return Person._gender; } set { Person._gender = value; } }
        private int _id;
        public int Id { get { return _id; } set { _id = value; } }
        //实例方法
        public void M1() 
        {
            this._id = 1;
            Person._name = "男";
        }
        //静态方法
        public static void M2() 
        {
            //静态方法只可以访问静态成员和静态字段，用类名.方法名来访问
            Person._gender = '男';
        }
    }
}
