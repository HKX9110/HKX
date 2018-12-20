using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05动物类继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //多态 :声明父类去 指向子类对象
            Animal[] a = {new Cat(),new Dog(),new Pig()}; 
            for (int i = 0; i < a.Length; i++)
			{
			    a[i].Bark();
                a[i].Eat();
                a[i].Drink();
			}
        }
    }
    abstract class Animal   
    {
        //抽象成员只能存在于抽象类中
        public abstract void Bark();  // 父类无法确定子类是如何实现的时候用抽象方法

        public  void Eat()
        {
            Console.WriteLine("动物可以舔着吃饭");
        }

        public  void Drink()
        {
            Console.WriteLine("动物可以舔着喝水");
        }
    }


    //一个子类继承了抽象的父类，那么这个子类就必须重写这个父类的所有抽象成员
    class Cat:Animal
    {

        public override void Bark()
        {
            Console.WriteLine("喵咪喵喵的叫");
        }

        
    }
    class Dog:Animal
    {

        public override void Bark()
        {
            Console.WriteLine("小狗汪汪的叫");
        }

      
    }
    class Pig:Animal
    {

        public override void Bark()
        {
            Console.WriteLine("小猪哼哼的叫");
        }

     
    }
}
