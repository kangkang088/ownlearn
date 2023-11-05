using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10监控预警系统.Models {
    /// <summary>
    /// 从站信息类
    /// </summary>
    public class SlaveInfo {
        public byte SlaveId { get; set; }
        public byte FunctionCode { get; set; }
        public ushort StartAddress { get; set; }
        public ushort Count { get; set; }   
    }
}
