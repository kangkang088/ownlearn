using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05索引器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student["math"] = 90;
            student["math"] = 100;
            var mathScore = student["math"];
            Console.WriteLine(mathScore);
        }
    }
    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();
        public int? this[string subject]
        {
            get 
            {
                if(this.scoreDictionary.ContainsKey(subject))
                    return this.scoreDictionary[subject];
                return null;
            }
            set 
            {
                if(value.HasValue == false) { throw new Exception("Score cannot be null"); }
                if (this.scoreDictionary.ContainsKey(subject))
                    this.scoreDictionary[subject] = value.Value;
                else
                    this.scoreDictionary.Add(subject, value.Value);

            }
        }
    }
}
