using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05序列化与反序列化
{
    [Serializable]
    internal class Student
    {
        public string StuName { get; set; }    
        public int StuNum { get; set; }
        public int StuAge { get; set; }
    }
}
