using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 串口助手 {
    public class SimpleDecodedDataFrame : DecodeData {
        private bool isHeadReceive = false;
        private int frameLength;
        private bool checkOk = false;

        //普通数据帧解析
        public override byte[] decodeDataFrame(Queue<byte> buffer) {
            if (isHeadReceive == false) { //从帧头开始接收数据，如果当前开始的数据不是帧头的数据，全部去掉
                foreach (byte item in buffer) {
                    if (item != 0x7f) {
                        buffer.Dequeue();//出列-循环去掉数据
                    }
                    else {
                        isHeadReceive = true;//接收到帧头，把帧头标识设为true表示当前队列是从帧头开始的。停止循环
                        break;//队列（以帧头开始）处理完毕
                    }
                }
            }
            if (isHeadReceive == true) { //到达帧头了
                isHeadReceive = false;//重置帧头标识。重新处理队列
                //判断是否有数据帧长度，如果队列长度就是一，说明只有一个帧头
                if (buffer.Count >= 2) {
                    frameLength = buffer.ToArray()[1];//拿到帧包含的数据的长度
                    //获取数据（一帧完整的数据长度的判断，不代表数据是正确的，还需要校验）
                    if (buffer.Count >= 1 + 1 + frameLength + 2) {
                        byte[] frameBuffer = new byte[1 + 1 + frameLength + 2];//将待校验的数据帧存入字节数据
                        Array.Copy(buffer.ToArray(), 0, frameBuffer, 0, frameBuffer.Length);
                        //校验
                        if (crc_check(frameBuffer)) {
                            Console.WriteLine("frame is check correctly!");
                            checkOk = true;
                        }
                        else {
                            //无效数据
                            Console.WriteLine("bad frame,drop it!");
                            for (int i = 0; i < 1 + 1 + frameLength + 2; i++) {
                                buffer.Dequeue();//不论数据是否正确，都要出列
                            }
                        }
                        if (checkOk) {
                            checkOk = false;
                            return frameBuffer;
                        }
                    }
                }
            }
            return null;
        }
        private bool crc_check(byte[] frameBuffer) {
            //解析帧--考虑大小端问题
            /*大端模式：是指数据的高字节保存在内存的低地址中，而数据的低字节保存在内存的高地址中，这样的存储模式有点儿类似于把数据当作字符串顺序处理。地址由小向大增加，而数据从高位往低位放；这和我们的阅读习惯一致。
              小端模式：是指数据的高字节保存在内存的高地址中,而数据的低字节保存在内存的低地址中，这种存储模式将地址的高低和数据位权有效地结合起来，高
              地址部分权值高，低地址部分权值低。*/

            bool ret = false;//校验位检测标识
            byte[] temp = new byte[frameBuffer.Length - 2];//获取数据帧，去除CRC长度
            Array.Copy(frameBuffer, 0, temp, 0, temp.Length);
            byte[] crcData = DataCheck.DataCrc16_Ccitt(temp, DataCheck.BigOrLittle.BigEndian);//获取指定校验方法的校验位
            if (crcData[0] == frameBuffer[frameBuffer.Length - 2] && crcData[1] == frameBuffer[frameBuffer.Length - 1]) {
                ret = true;//校验位正确
            }
            return ret;
        }
    }
}
