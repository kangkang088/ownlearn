using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dem1
{
    [Serializable]
    internal class Person
    {
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }
        private char _gender;
        public char Gender { get { return _gender; } set { _gender = value; } }
        private int _age;
        public int Age { get { return _age; } set { _age = value; } }
    }
}
