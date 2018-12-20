using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04三个关键字
{
    /// <summary>
    /// new 
    ///    1、创建对象（在堆中开辟空间 在开辟的空间中创建对象  调用对象的构造函数）
    ///    2、new 隐藏父类的成员
    ///this
    ///    1、代表当前类的对象
    ///    2、显示的调用自己的构造函数
    ///base
    ///    1、显示的调用父类的构造函数  
    ///    2、调用父类的成员 
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //Student stu = new Student();   // new 第一个用法 创建对象（1、在堆中开辟空间 2、在开辟的空间中创建对象 3、调用对象构造函数）
            //stu.SayHello();
            //stu.Name = "大黄老师";
            //stu.Test();

            Teacher t = new Teacher("大黄老师", 18, '女', 50, 50, 50);
            t.SayHi();
            t.ShowScore();

            Teacher t2 = new Teacher("春老师", 18, '女');
            t2.SayHi();
        }
    }

    class Person
    {
        public void SayHello()
        {
            Console.WriteLine("I am a Person!");
        }
    }

    class Student:Person
    {
        public new void SayHello()      // new 第二个用法 隐藏父类成员
        {
            Console.WriteLine("I am a Student!");
        }

        public string Name { get; set; }

        public void Test()
        {
            //在函数中局部变量优先级高于成员变量
            string Name = "春生老师";      //局部变量
            Console.WriteLine("我的名字叫{0}",this.Name);   //this 第一个用法 代表当前类的对象
        }
    }

    class Teacher
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public char Gender { get; set; }

        public int Chinese { get; set; }

        public int Math { get; set; }

        public int English { get; set; }

        public Teacher(string Name,int Age,char Gender,int Chinese,int Math,int English)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
            this.Chinese = Chinese;
            this.Math = Math;
            this.English = English;
        }

        public Teacher(string Name,int Age,char Gender):this(Name,Age,Gender,0,0,0) //this 第二个用法 显示的调用自己的构造函数
        {
                
        }
        public void SayHi()
        {
            Console.WriteLine("我叫{0}，今年{1}岁了，我是{2}生",this.Name,this.Age,this.Gender);
        }

        public void ShowScore()
        {
            Console.WriteLine("我叫{0}，我的总成绩{1}，平均成绩{2}",this.Name,this.Chinese+this.Math+this.English,
                (this.Chinese + this.Math + this.English)/3);
        }
    }
}
