using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串口助手 {
    public delegate void TransmitData(byte[] data);
    public delegate void TransmitDataEventHandler(object sender,TransmitEventArgs eventArgs);
    public class TransmitEventArgs : EventArgs {
        public byte[] data { get; set; }
    }
}
