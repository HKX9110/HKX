using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student outStu = new Student();
            outStu.name = "Tim";
            Console.WriteLine("HashCode={0} Name={1}", outStu.GetHashCode(), outStu.name);
            Console.WriteLine("---------------------------------------------------------");
            SomeSideEffect(outStu);
            Console.WriteLine("HashCode={0} Name={1}", outStu.GetHashCode(), outStu.name);
        }

        static void SomeSideEffect(Student stu)
        {
            stu.name = "TOM";
            Console.WriteLine("HashCode={0} Name={1}",stu.GetHashCode(),stu.name);
        }
    }
    class Student
    {
        public string name { get; set; }
    }
}
