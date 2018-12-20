using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16剪刀石头布
{
    class Computer
    {
        Random r = new Random();
        public string Fist { get; set; }
        public int ChuQuan()
        {
            int res = 0;
            res=r.Next(1, 4);
            switch (res)
            {
                case 1:
                    Fist = "石头";
                    break;
                case 2:
                    Fist = "剪刀";
                    break;
                case 3:
                    Fist="布";
                    break;
            }
            return res;
        }
    }
}
