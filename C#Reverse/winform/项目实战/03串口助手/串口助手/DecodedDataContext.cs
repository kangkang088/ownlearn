using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串口助手 {
    public class DecodedDataContext {
        private DecodeData _data;

        public DecodedDataContext(DecodeData data) {
            _data = data;
        }
        public byte[] GetDataFrame(Queue<byte> buffer) {
            return this._data.decodeDataFrame(buffer);
        }
    }
}
