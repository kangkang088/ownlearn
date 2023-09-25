using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15石头剪刀布
{
    public enum Result
    {
        玩家赢,
        电脑赢,
        平局
    }
    internal class CaiPan
    {
        public static Result Judge(int playNumber, int CpuNumber)
        {
            if (playNumber - CpuNumber == -1 || playNumber - CpuNumber == 2)
            {
                return Result.玩家赢;
            }
            else if (playNumber - CpuNumber == 0)
            {
                return Result.平局;
            }
            else { return Result.电脑赢; }
        }
    }
}
