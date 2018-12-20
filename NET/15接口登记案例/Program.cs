using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15接口登记案例
{
    class Program
    {
        static void Main(string[] args)
        {
            //房子、车子、person、财产登记
            //最后写一个函数来实现登记
            Denji(new Person());
            Denji(new House());
            Denji(new Car());
            Denji(new Money());
        }
        static void Denji(IDenji dj)
        {
            dj.Denji();
        }
    }
    interface IDenji
    {
        void Denji();
    }
    class House:IDenji
    {

        public void Denji()
        {
            Console.WriteLine("房子需要登记");
        }
    }
    class Person:IDenji
    {

        public void Denji()
        {
            Console.WriteLine("人出生要登记");
        }
    }
    class Car:IDenji
    {

        public void Denji()
        {
            Console.WriteLine("汽车需要登记");
        }
    }
    class Money:IDenji
    {

        public void Denji()
        {
            Console.WriteLine("财产需要登记");
        }
    }
}
