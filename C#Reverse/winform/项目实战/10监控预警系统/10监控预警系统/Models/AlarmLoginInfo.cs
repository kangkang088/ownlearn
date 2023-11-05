using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10监控预警系统.Models {
    /// <summary>
    /// 预警信息记录类
    /// </summary>
    public class AlarmLoginInfo {
        public int Id { get; set; }
        public DateTime AlarmTime { get; set; }
        public string ParaName { get; set; }
        public int AlarmType { get; set; }
        public string AlarmState { get; set; }
        public int Value { get; set; }
        public string AlarmNote { get; set; }

        public AlarmLoginInfo(int id, DateTime alarmTime, string paraName, int alarmType, string alarmState, int value, string alarmNote) {
            Id = id;
            AlarmTime = alarmTime;
            ParaName = paraName;
            AlarmType = alarmType;
            AlarmState = alarmState;
            Value = value;
            AlarmNote = alarmNote;
        }
    }
}
