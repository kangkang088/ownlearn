using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 将移动硬盘_u盘或mp3插到电脑上进行读写数据
{
    internal class Computer
    {
        private MobileStorage _ms;
        public MobileStorage MS{ get { return _ms; } set { _ms = value; } }
        public void CpuRead()
        {
            MS.Read();
        }
        public void CpuWrite() 
        {
            MS.Write();
        }
    }
}
