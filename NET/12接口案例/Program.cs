using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12接口案例
{
    class Program
    {
        static void Main(string[] args)
        {
            IFly[] flys = {new YinWu(),new MaBird(),new Plane()};
            for (int i = 0; i < flys.Length; i++)
            {
                flys[i].fly();
            }
            
        }
    }
    class Brid
    {
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
    }

    interface IFly
    {
        void fly();
    }

    class YinWu:Brid,IFly
    {

        public void fly()
        {
            Console.WriteLine("鹦鹉会飞");
        }
    }
    class MaBird:Brid,IFly
    {

        public void fly()
        {
            Console.WriteLine("麻雀会飞");
        }
    }
    class TuoBrid:Brid
    {

    }
    class QQ:Brid
    {

    }
    class Plane:IFly
    {

        public void fly()
        {
            Console.WriteLine("飞机也会飞");
        }
    }
}
