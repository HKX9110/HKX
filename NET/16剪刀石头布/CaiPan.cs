using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _18访问修饰符;

namespace _16剪刀石头布
{
    enum Result
    {
        玩家赢,
        电脑赢,
        平手
    }
    class CaiPan
    {
        public Result GetResult(int playNumber,int cpuNumber)
        {
            if(playNumber-cpuNumber==-1||playNumber-cpuNumber==2)
            {
                return Result.玩家赢;
            }
            else if(playNumber-cpuNumber==0)
            {
                return Result.平手;
            }
            else
            {
                return Result.电脑赢;
            }
           

        }
    }
}
