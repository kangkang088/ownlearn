using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Administrator\\Desktop\\111.txt";
            string pathNew = Path.ChangeExtension(path, "jpeg");
            string pathDirectory = Path.GetDirectoryName(pathNew);
            Console.WriteLine(pathDirectory);
            Console.WriteLine(pathNew);
        }
    }
}
