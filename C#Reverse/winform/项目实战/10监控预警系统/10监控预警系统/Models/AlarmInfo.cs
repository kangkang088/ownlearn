using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10监控预警系统.Models {
    /// <summary>
    /// 报警信息设置类
    /// </summary>
    public class AlarmInfo {
        public string ParaType { get; set; }
        public int AlarmType { get; set; }
        public string AlarmValue  { get; set; }  
    }
}
