using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将移动硬盘_u盘或mp3插到电脑上进行读写数据
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileStorage ms = new UDisk();
            Computer cpu = new Computer();
            cpu.MS = ms;
            cpu.CpuRead();
            cpu.CpuWrite();
        }
    }
}
