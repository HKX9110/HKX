using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13显示实现接口
{
    class Program
    {
        static void Main(string[] args)
        {
            I1 i = new Person();
            i.test();
        }
    }
    class Person:I1
    {
        public void test()
        {
            Console.WriteLine("这是person类的test方法");
        }
        //显示的实现接口
        void I1.test()
        {
            Console.WriteLine("显示实现接口test方法");
        }
    }
    interface I1
    {
        void test();
    }
}
