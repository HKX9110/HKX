using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.Brak();
        }
    }
    abstract class Animal
    {
        public abstract void Brak();
    }
    class Cat:Animal
    {

        public override void Brak()
        {
            Console.WriteLine("喵喵");
        }
    }
    class Dog:Animal
    {

        public override void Brak()
        {
            Console.WriteLine("汪汪");
        }
    }
    class Pig:Animal
    {

        public override void Brak()
        {
            Console.WriteLine("哼哼");
        }
    }
}
