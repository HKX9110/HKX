using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p._gender='女';
            p._math=100;
        }
    }

   public class Person
    {
        public string _name;
        private int _age;
        internal char _gender;
        protected int Chinese;
        protected internal int _math;

    }
    class Student:Person
    { 
        public void Test()
        {
            
        }
    }

}
