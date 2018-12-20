using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03面向对象复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "李四";
            p.Age = -19;
            Console.WriteLine(p.Age);
        }
    }
    class Person
    {
        //字段、属性、函数、构造函数。。。。
        //字段：存储数据
        //属性：保护字段 get set
        //函数：描述对象的行为
        //构造函数：初始化对象，给对象的每个属性赋值

        private string _name;

        public string Name
        {
            get { return _name; }  //对属性取值 给的是字段的值
            set
            {
                if (value!="张三")
                {
                    value = "张三";
                } 
                _name = value;} //给属性赋值 给字段赋值
        }

        int _age;

        public int Age
        {
            get
            {
                if (_age <0||_age>100)
                {
                    return _age = 18;
                } return _age;
            }
            set { _age = value; }
        }
    }
}
