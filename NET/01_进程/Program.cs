using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace _01_进程
{
    class Program
    {
        static void Main(string[] args)
        {
            //Process[] pro = Process.GetProcesses();
            //foreach (var item in pro)
            //{
            //    Console.WriteLine(item.ProcessName);
            //}
            //Process.Start("notepad++");
            //Process.Start("mspaint");
            //Process.Start("calc");
            //Process.Start("iexplore", "http://www.sina.com");

            //使用进程打开文件
            ProcessStartInfo psi = new ProcessStartInfo("C:\\Users\\Administrator\\Desktop\\1.txt");
            //创建进程对象
            Process pro = new Process();
            //告诉进程要打开的文件
            pro.StartInfo=psi;
            //调用函数打开
            pro.Start();
        }
    }
}
