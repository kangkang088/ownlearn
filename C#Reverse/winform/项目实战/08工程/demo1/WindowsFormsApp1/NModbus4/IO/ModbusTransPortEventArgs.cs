using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modbus {
    public class ModbusTransPortEventArgs:EventArgs {
        private readonly byte[] _message;

        public ModbusTransPortEventArgs(byte[] message) {
            _message = message;
        }
        public byte[] Message {
            get{ return _message; }
        }
    }
}
