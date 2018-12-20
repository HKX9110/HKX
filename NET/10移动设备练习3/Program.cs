using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10移动设备练习
{
    class Program
    {
        static void Main(string[] args)
        {
            MobileDisk md = new MobileDisk();
            UDisk ud = new UDisk();
            Mp3 mp3 = new Mp3();
            Telephone tel = new Telephone();

            Computer c = new Computer();
            c.MS = tel; //mp3;       
            c.MS.Read();
            c.MS.Write();
        }
    }
    abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    class Telephone:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("手机读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("手机写入数据");
        }
    }
    class MobileDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘写入数据");
        }
    }

    class UDisk:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("U盘写入数据");
        }
    }
    class Mp3:MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("Mp3读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("Mp3写入数据");
        }
        public void MusicPlay()
        {
            Console.WriteLine("Mp3播放音乐");
        }
    }

    class Computer
    {
        public MobileStorage MS { get; set; }
        public void CpuRead(MobileStorage ms)
        {
            this.MS.Read();
        }
        public void CpuWrite(MobileStorage ms)
        {
            this.MS.Write();
        }
    }
}
