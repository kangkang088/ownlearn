using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02进程
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("C:\\Users\\Administrator\\Desktop\\111.txt");
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.Start();
        }
    }
}
