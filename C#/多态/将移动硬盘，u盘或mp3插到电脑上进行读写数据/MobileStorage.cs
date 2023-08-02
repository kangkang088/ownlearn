using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将移动硬盘_u盘或mp3插到电脑上进行读写数据
{
    internal abstract class MobileStorage//移动存储设备
    {        
        public abstract void Read();
        public abstract void Write();
    }
}
