using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace _03字段field
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
           
        }
    }
    class Student
    {
        public readonly int Id = 100;
        public Student() 
        {
            this.Id = 0;
        }
        public int age;
        public int score;
        public static int avgAge;
        public static int avgScore;
        public static int sum;
        
       
    }
}
