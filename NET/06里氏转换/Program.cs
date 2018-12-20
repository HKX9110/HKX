using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06里氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student();                   //子类可以赋值给父类
            if(person is Teacher)
            {
                ((Teacher)person).TeacherSayHi();        
            }
            else
            {
                Console.WriteLine("转换失败!");
            }
            Student s = (Student)person;                    //父类中装的是子类对象studnet 所以可以转换为student对象
            if(s!=null)
            {
                s.StudentSayHi();
            }
            else
            {
                Console.WriteLine("转换失败");
            }

        }
    }
    class Person
    {
        public void PersonSayHi()
        {
            Console.WriteLine("我是父类");
        }
    }
    class Student:Person
    {
        public void StudentSayHi()
        {
            Console.WriteLine("我是学生");
        }
    }
    class Teacher:Person
    {
        public void TeacherSayHi()
        {
            Console.WriteLine("我是老师");
        }
    }
}
