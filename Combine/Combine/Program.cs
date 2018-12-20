using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combine
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static double Mul(double a , double b)
        {
            return a * b;
        }

        
    }
    class Student
    {
        ~Student()
        {
            Console.WriteLine("over");
        }

    }
    
    delegate T Mydele<T>(T a,T b);
    delegate int Mydele(int a ,int b);
}
