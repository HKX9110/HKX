using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11接口的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            //实现多态
            IKouLan kl = new Studnet();
            kl.KouLan();
        }
    }
    class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("吃喝拉撒睡");
        }
    }
    class Studnet:Person,IKouLan
    {

        public void KouLan()
        {
            Console.WriteLine("学生可以扣篮");
        }
    }
    class NBAplayer:Person,IKouLan
    {

        public void KouLan()
        {
            Console.WriteLine("NBA运动员可以扣篮");
        }
    }
    class Teacher:Person,IKouLan
    {

        public void KouLan()
        {
            Console.WriteLine("老师可以扣篮");
        }
    }
    class Diver:Person,IKouLan
    {

        public void KouLan()
        {
            Console.WriteLine( "司机可以扣篮");
        }
    }
    class NoLeg:Person
    {

    }

    interface IKouLan
    {
        void KouLan();
    }
}
