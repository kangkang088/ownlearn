using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串口助手 {
    public class ModbusDecodedData : DecodeData {
        //modbus方式解析
        public override byte[] decodeDataFrame(Queue<byte> buffer) {
            return null;
        }
    }
}
