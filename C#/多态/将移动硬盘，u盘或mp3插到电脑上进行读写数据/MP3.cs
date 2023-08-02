using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将移动硬盘_u盘或mp3插到电脑上进行读写数据
{
    internal class MP3:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }
    }
}
