using _10监控预警系统.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10监控预警系统 {
    public class CommonClass {
        public static List<AlarmLoginInfo> logList = new List<AlarmLoginInfo>();//存储预警记录信息
        public static event Action UpdateAlarmLogList;//更新预警列表
        //调用更新事件
        public static void UpdateDGVAlarmList() {
            UpdateAlarmLogList?.Invoke();
        }
    }
}
