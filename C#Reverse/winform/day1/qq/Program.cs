using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Tencent\QQ\Bin\QQ.exe");
            Process process = new Process();
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
