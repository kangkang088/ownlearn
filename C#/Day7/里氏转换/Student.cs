﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换
{
    internal class Student:Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }
}
